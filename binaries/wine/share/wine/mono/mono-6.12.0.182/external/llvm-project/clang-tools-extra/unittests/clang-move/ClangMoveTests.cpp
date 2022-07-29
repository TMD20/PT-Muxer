//===-- ClangMoveTest.cpp - clang-move unit tests -------------------------===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#include "ClangMove.h"
#include "unittests/Tooling/RewriterTestContext.h"
#include "clang/Format/Format.h"
#include "clang/Frontend/FrontendActions.h"
#include "clang/Frontend/TextDiagnosticPrinter.h"
#include "clang/Rewrite/Core/Rewriter.h"
#include "clang/Tooling/Refactoring.h"
#include "clang/Tooling/Tooling.h"
#include "llvm/ADT/StringRef.h"
#include "gtest/gtest.h"
#include <string>
#include <vector>

namespace clang {
namespace move {
namespace {

const char TestHeaderName[] = "foo.h";

const char TestCCName[] = "foo.cc";

const char TestHeader[] = "namespace a {\n"
                          "class C1; // test\n"
                          "template <typename T> class C2;\n"
                          "namespace b {\n"
                          "// This is a Foo class\n"
                          "// which is used in\n"
                          "// test.\n"
                          "class Foo {\n"
                          "public:\n"
                          "  void f();\n"
                          "\n"
                          "private:\n"
                          "  C1 *c1;\n"
                          "  static int b;\n"
                          "}; // abc\n"
                          "\n"
                          "class Foo2 {\n"
                          "public:\n"
                          "  int f();\n"
                          "};\n"
                          "} // namespace b\n"
                          "} // namespace a\n";

const char TestCC[] = "#include \"foo.h\"\n"
                      "namespace a {\n"
                      "namespace b {\n"
                      "namespace {\n"
                      "// comment1.\n"
                      "void f1() {}\n"
                      "/// comment2.\n"
                      "int kConstInt1 = 0;\n"
                      "} // namespace\n"
                      "\n"
                      "/* comment 3*/\n"
                      "static int kConstInt2 = 1;\n"
                      "\n"
                      "/** comment4\n"
                      " */\n"
                      "static int help() {\n"
                      "  int a = 0;\n"
                      "  return a;\n"
                      "}\n"
                      "\n"
                      "// comment5\n"
                      "// comment5\n"
                      "void Foo::f() {\n"
                      "  f1();\n"
                      "  kConstInt1;\n"
                      "  kConstInt2;\n"
                      "  help();\n"
                      "}\n"
                      "\n"
                      "/////////////\n"
                      "// comment //\n"
                      "/////////////\n"
                      "int Foo::b = 2;\n"
                      "int Foo2::f() {\n"
                      "  kConstInt1;\n"
                      "  kConstInt2;\n"
                      "  help();\n"
                      "  f1();\n"
                      "  return 1;\n"
                      "}\n"
                      "} // namespace b\n"
                      "} // namespace a\n";

const char ExpectedTestHeader[] = "namespace a {\n"
                                  "class C1; // test\n"
                                  "template <typename T> class C2;\n"
                                  "namespace b {\n"
                                  "\n"
                                  "class Foo2 {\n"
                                  "public:\n"
                                  "  int f();\n"
                                  "};\n"
                                  "} // namespace b\n"
                                  "} // namespace a\n";

const char ExpectedTestCC[] = "#include \"foo.h\"\n"
                              "namespace a {\n"
                              "namespace b {\n"
                              "namespace {\n"
                              "// comment1.\n"
                              "void f1() {}\n"
                              "/// comment2.\n"
                              "int kConstInt1 = 0;\n"
                              "} // namespace\n"
                              "\n"
                              "/* comment 3*/\n"
                              "static int kConstInt2 = 1;\n"
                              "\n"
                              "/** comment4\n"
                              " */\n"
                              "static int help() {\n"
                              "  int a = 0;\n"
                              "  return a;\n"
                              "}\n"
                              "\n"
                              "int Foo2::f() {\n"
                              "  kConstInt1;\n"
                              "  kConstInt2;\n"
                              "  help();\n"
                              "  f1();\n"
                              "  return 1;\n"
                              "}\n"
                              "} // namespace b\n"
                              "} // namespace a\n";

const char ExpectedNewHeader[] = "#ifndef NEW_FOO_H\n"
                                 "#define NEW_FOO_H\n"
                                 "\n"
                                 "namespace a {\n"
                                 "class C1; // test\n"
                                 "\n"
                                 "template <typename T> class C2;\n"
                                 "namespace b {\n"
                                 "// This is a Foo class\n"
                                 "// which is used in\n"
                                 "// test.\n"
                                 "class Foo {\n"
                                 "public:\n"
                                 "  void f();\n"
                                 "\n"
                                 "private:\n"
                                 "  C1 *c1;\n"
                                 "  static int b;\n"
                                 "}; // abc\n"
                                 "} // namespace b\n"
                                 "} // namespace a\n"
                                 "\n"
                                 "#endif // NEW_FOO_H\n";

const char ExpectedNewCC[] = "namespace a {\n"
                             "namespace b {\n"
                             "namespace {\n"
                             "// comment1.\n"
                             "void f1() {}\n"
                             "\n"
                             "/// comment2.\n"
                             "int kConstInt1 = 0;\n"
                             "} // namespace\n"
                             "\n"
                             "/* comment 3*/\n"
                             "static int kConstInt2 = 1;\n"
                             "\n"
                             "/** comment4\n"
                             " */\n"
                             "static int help() {\n"
                             "  int a = 0;\n"
                             "  return a;\n"
                             "}\n"
                             "\n"
                             "// comment5\n"
                             "// comment5\n"
                             "void Foo::f() {\n"
                             "  f1();\n"
                             "  kConstInt1;\n"
                             "  kConstInt2;\n"
                             "  help();\n"
                             "}\n"
                             "\n"
                             "/////////////\n"
                             "// comment //\n"
                             "/////////////\n"
                             "int Foo::b = 2;\n"
                             "} // namespace b\n"
                             "} // namespace a\n";

std::map<std::string, std::string>
runClangMoveOnCode(const move::MoveDefinitionSpec &Spec,
                   const char *const Header = TestHeader,
                   const char *const CC = TestCC,
                   DeclarationReporter *const Reporter = nullptr) {
  clang::RewriterTestContext Context;

  std::map<llvm::StringRef, clang::FileID> FileToFileID;
  std::vector<std::pair<std::string, std::string>> FileToSourceText = {
      {TestHeaderName, Header}, {TestCCName, CC}};

  auto CreateFiles = [&Context, &FileToFileID](llvm::StringRef Name,
                                               llvm::StringRef Code) {
    if (!Name.empty()) {
      FileToFileID[Name] = Context.createInMemoryFile(Name, Code);
    }
  };
  CreateFiles(Spec.NewCC, "");
  CreateFiles(Spec.NewHeader, "");
  CreateFiles(Spec.OldHeader, Header);
  CreateFiles(Spec.OldCC, CC);

  std::map<std::string, tooling::Replacements> FileToReplacements;
  llvm::SmallString<128> InitialDirectory;
  std::error_code EC = llvm::sys::fs::current_path(InitialDirectory);
  assert(!EC);
  (void)EC;
  ClangMoveContext MoveContext = {Spec, FileToReplacements,
                                  InitialDirectory.str(), "LLVM",
                                  Reporter != nullptr};

  auto Factory = llvm::make_unique<clang::move::ClangMoveActionFactory>(
      &MoveContext, Reporter);

  tooling::runToolOnCodeWithArgs(
      Factory->create(), CC, {"-std=c++11", "-fparse-all-comments"},
      TestCCName, "clang-move", std::make_shared<PCHContainerOperations>(),
      FileToSourceText);
  formatAndApplyAllReplacements(FileToReplacements, Context.Rewrite, "llvm");
  // The Key is file name, value is the new code after moving the class.
  std::map<std::string, std::string> Results;
  for (const auto &It : FileToReplacements) {
    StringRef FilePath = It.first;
    Results[FilePath] = Context.getRewrittenText(FileToFileID[FilePath]);
  }
  return Results;
}

TEST(ClangMove, MoveHeaderAndCC) {
  move::MoveDefinitionSpec Spec;
  Spec.Names = {std::string("a::b::Foo")};
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  std::string ExpectedHeader = "#include \"" + Spec.NewHeader + "\"\n\n";
  auto Results = runClangMoveOnCode(Spec);
  EXPECT_EQ(ExpectedTestHeader, Results[Spec.OldHeader]);
  EXPECT_EQ(ExpectedTestCC, Results[Spec.OldCC]);
  EXPECT_EQ(ExpectedNewHeader, Results[Spec.NewHeader]);
  EXPECT_EQ(ExpectedHeader + ExpectedNewCC, Results[Spec.NewCC]);
}

TEST(ClangMove, MoveHeaderOnly) {
  move::MoveDefinitionSpec Spec;
  Spec.Names = {std::string("a::b::Foo")};
  Spec.OldHeader = "foo.h";
  Spec.NewHeader = "new_foo.h";
  auto Results = runClangMoveOnCode(Spec);
  EXPECT_EQ(2u, Results.size());
  EXPECT_EQ(ExpectedTestHeader, Results[Spec.OldHeader]);
  EXPECT_EQ(ExpectedNewHeader, Results[Spec.NewHeader]);
}

TEST(ClangMove, MoveCCOnly) {
  move::MoveDefinitionSpec Spec;
  Spec.Names = {std::string("a::b::Foo")};
  Spec.OldCC = "foo.cc";
  Spec.NewCC = "new_foo.cc";
  std::string ExpectedHeader = "#include \"foo.h\"\n\n";
  auto Results = runClangMoveOnCode(Spec);
  EXPECT_EQ(2u, Results.size());
  EXPECT_EQ(ExpectedTestCC, Results[Spec.OldCC]);
  EXPECT_EQ(ExpectedHeader + ExpectedNewCC, Results[Spec.NewCC]);
}

TEST(ClangMove, MoveNonExistClass) {
  move::MoveDefinitionSpec Spec;
  Spec.Names = {std::string("NonExistFoo")};
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  auto Results = runClangMoveOnCode(Spec);
  EXPECT_EQ(0u, Results.size());
}

TEST(ClangMove, MoveAll) {
  std::vector<std::string> TestHeaders = {
    "class A {\npublic:\n  int f();\n};",
    // forward declaration.
    "class B;\nclass A {\npublic:\n  int f();\n};",
    // template forward declaration.
    "template <typename T> class B;\nclass A {\npublic:\n  int f();\n};",
    "namespace a {}\nclass A {\npublic:\n  int f();\n};",
    "namespace a {}\nusing namespace a;\nclass A {\npublic:\n  int f();\n};",
  };
  const char Code[] = "#include \"foo.h\"\nint A::f() { return 0; }";
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("A");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  for (const auto& Header : TestHeaders) {
    auto Results = runClangMoveOnCode(Spec, Header.c_str(), Code);
    EXPECT_EQ(Header, Results[Spec.NewHeader]);
    EXPECT_EQ("", Results[Spec.OldHeader]);
    EXPECT_EQ("", Results[Spec.OldCC]);
  }
}

TEST(ClangMove, MoveAllMultipleClasses) {
  move::MoveDefinitionSpec Spec;
  std::vector<std::string> TestHeaders = {
    "class C;\nclass A {\npublic:\n  int f();\n};\nclass B {};",
    "class C;\nclass B;\nclass A {\npublic:\n  int f();\n};\nclass B {};",
  };
  const char Code[] = "#include \"foo.h\"\nint A::f() { return 0; }";
  Spec.Names = {std::string("A"), std::string("B")};
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  for (const auto& Header : TestHeaders) {
    auto Results = runClangMoveOnCode(Spec, Header.c_str(), Code);
    EXPECT_EQ(Header, Results[Spec.NewHeader]);
    EXPECT_EQ("", Results[Spec.OldHeader]);
    EXPECT_EQ("", Results[Spec.OldCC]);
  }
}

TEST(ClangMove, DontMoveAll) {
  const char ExpectedHeader[] = "#ifndef NEW_FOO_H\n"
                                "#define NEW_FOO_H\n"
                                "\n"
                                "class A {\npublic:\n  int f();\n};\n"
                                "\n"
                                "#endif // NEW_FOO_H\n";
  const char Code[] = "#include \"foo.h\"\nint A::f() { return 0; }";
  std::vector<std::string> TestHeaders = {
    "class B {};\nclass A {\npublic:\n  int f();\n};\n",
    "void f() {};\nclass A {\npublic:\n  int f();\n};\n",
  };
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("A");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  for (const auto& Header : TestHeaders) {
    auto Results = runClangMoveOnCode(Spec, Header.c_str(), Code);
    EXPECT_EQ(ExpectedHeader, Results[Spec.NewHeader]);
    // The expected old header should not contain class A definition.
    std::string ExpectedOldHeader = Header.substr(0, Header.size() - 32);
    EXPECT_EQ(ExpectedOldHeader, Results[Spec.OldHeader]);
  }
}

TEST(ClangMove, MacroInFunction) {
  const char TestHeader[] = "#define INT int\n"
                            "class A {\npublic:\n  int f();\n};\n"
                            "class B {};\n";
  const char TestCode[] = "#include \"foo.h\"\n"
                          "INT A::f() { return 0; }\n";
  const char ExpectedNewCode[] = "#include \"new_foo.h\"\n\n"
                                 "INT A::f() { return 0; }\n";
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("A");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  auto Results = runClangMoveOnCode(Spec, TestHeader, TestCode);
  EXPECT_EQ(ExpectedNewCode, Results[Spec.NewCC]);
}

TEST(ClangMove, DefinitionInMacro) {
  const char TestHeader[] = "#define DEF(CLASS) void CLASS##_::f() {}\n"
                            "class A_ {\nvoid f();\n};\n"
                            "class B {};\n";
  const char TestCode[] = "#include \"foo.h\"\n"
                          "DEF(A)\n";
  const char ExpectedNewCode[] = "#include \"new_foo.h\"\n\n"
                                 "DEF(A)\n";
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("A_");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  auto Results = runClangMoveOnCode(Spec, TestHeader, TestCode);
  EXPECT_EQ(ExpectedNewCode, Results[Spec.NewCC]);
}

TEST(ClangMove, WellFormattedCode) {
  const std::string CommonHeader =
      "namespace a {\n"
      "namespace b {\n"
      "namespace c {\n"
      "class C;\n"
      "\n"
      "class A {\npublic:\n  void f();\n  void f2();\n};\n"
      "} // namespace c\n"
      "} // namespace b\n"
      "\n"
      "namespace d {\n"
      "namespace e {\n"
      "class B {\npublic:\n  void f();\n};\n"
      "} // namespace e\n"
      "} // namespace d\n"
      "} // namespace a\n";
  const std::string CommonCode = "\n"
                                 "namespace a {\n"
                                 "namespace b {\n"
                                 "namespace c {\n"
                                 "void A::f() {}\n"
                                 "\n"
                                 "void A::f2() {}\n"
                                 "} // namespace c\n"
                                 "} // namespace b\n"
                                 "\n"
                                 "namespace d {\n"
                                 "namespace e {\n"
                                 "void B::f() {}\n"
                                 "} // namespace e\n"
                                 "} // namespace d\n"
                                 "} // namespace a\n";
  // Add dummy class to prevent behavior of moving all declarations from header.
  const std::string TestHeader = CommonHeader + "class D {};\n";
  const std::string TestCode = "#include \"foo.h\"\n" + CommonCode;
  const std::string ExpectedNewHeader = "#ifndef NEW_FOO_H\n"
                                        "#define NEW_FOO_H\n"
                                        "\n" +
                                        CommonHeader +
                                        "\n"
                                        "#endif // NEW_FOO_H\n";
  const std::string ExpectedNewCC = "#include \"new_foo.h\"\n" + CommonCode;
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("a::b::c::A");
  Spec.Names.push_back("a::d::e::B");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  auto Results = runClangMoveOnCode(Spec, TestHeader.c_str(), TestCode.c_str());
  EXPECT_EQ(ExpectedNewCC, Results[Spec.NewCC]);
  EXPECT_EQ(ExpectedNewHeader, Results[Spec.NewHeader]);
}

TEST(ClangMove, AddDependentNewHeader) {
  const char TestHeader[] = "class A {};\n"
                            "class B {};\n";
  const char TestCode[] = "#include \"foo.h\"\n";
  const char ExpectedOldHeader[] = "#include \"new_foo.h\"\nclass B {};\n";
  const char ExpectedNewHeader[] = "#ifndef NEW_FOO_H\n"
                                   "#define NEW_FOO_H\n"
                                   "\n"
                                   "class A {};\n"
                                   "\n"
                                   "#endif // NEW_FOO_H\n";
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("A");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  Spec.OldDependOnNew = true;
  auto Results = runClangMoveOnCode(Spec, TestHeader, TestCode);
  EXPECT_EQ(ExpectedOldHeader, Results[Spec.OldHeader]);
  EXPECT_EQ(ExpectedNewHeader, Results[Spec.NewHeader]);
}

TEST(ClangMove, AddDependentOldHeader) {
  const char TestHeader[] = "class A {};\n"
                            "class B {};\n";
  const char TestCode[] = "#include \"foo.h\"\n";
  const char ExpectedNewHeader[] = "#ifndef NEW_FOO_H\n"
                                   "#define NEW_FOO_H\n"
                                   "\n"
                                   "#include \"foo.h\"\n"
                                   "\n"
                                   "class B {};\n"
                                   "\n"
                                   "#endif // NEW_FOO_H\n";
  const char ExpectedOldHeader[] = "class A {};\n";
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("B");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  Spec.NewDependOnOld = true;
  auto Results = runClangMoveOnCode(Spec, TestHeader, TestCode);
  EXPECT_EQ(ExpectedNewHeader, Results[Spec.NewHeader]);
  EXPECT_EQ(ExpectedOldHeader, Results[Spec.OldHeader]);
}

TEST(ClangMove, DumpDecls) {
  const char TestHeader[] = "template <typename T>\n"
                            "class A {\n"
                            " public:\n"
                            "  void f();\n"
                            "  template <typename U> void h();\n"
                            "  static int b;\n"
                            "};\n"
                            "\n"
                            "template <typename T> void A<T>::f() {}\n"
                            "\n"
                            "template <typename T>\n"
                            "template <typename U>\n"
                            "void A<T>::h() {}\n"
                            "\n"
                            "template <typename T> int A<T>::b = 2;\n"
                            "\n"
                            "template <> class A<int> {};\n"
                            "\n"
                            "class B {};\n"
                            "\n"
                            "namespace a {\n"
                            "class Move1 {};\n"
                            "void f1() {}\n"
                            "void f2();\n"
                            "} // namespace a\n"
                            "\n"
                            "class ForwardClass;\n"
                            "namespace a {\n"
                            "namespace b {\n"
                            "class Move1 { public : void f(); };\n"
                            "void f() {}\n"
                            "enum E1 { Green };\n"
                            "enum class E2 { Red };\n"
                            "typedef int Int2;\n"
                            "typedef A<double> A_d;"
                            "using Int = int;\n"
                            "extern int kGlobalInt;\n"
                            "extern const char* const kGlobalStr;\n"
                            "} // namespace b\n"
                            "} // namespace a\n";
  const char TestCode[] = "#include \"foo.h\"\n";
  move::MoveDefinitionSpec Spec;
  Spec.Names.push_back("B");
  Spec.OldHeader = "foo.h";
  Spec.OldCC = "foo.cc";
  Spec.NewHeader = "new_foo.h";
  Spec.NewCC = "new_foo.cc";
  DeclarationReporter Reporter;
  std::set<DeclarationReporter::DeclarationPair> ExpectedDeclarations = {
      {"A", "Class"},
      {"B", "Class"},
      {"a::Move1", "Class"},
      {"a::f1", "Function"},
      {"a::f2", "Function"},
      {"a::b::Move1", "Class"},
      {"a::b::f", "Function"},
      {"a::b::E1", "Enum"},
      {"a::b::E2", "Enum"},
      {"a::b::Int2", "TypeAlias"},
      {"a::b::A_d", "TypeAlias"},
      {"a::b::Int", "TypeAlias"},
      {"a::b::kGlobalInt", "Variable"},
      {"a::b::kGlobalStr", "Variable"}};
  runClangMoveOnCode(Spec, TestHeader, TestCode, &Reporter);
  std::set<DeclarationReporter::DeclarationPair> Results;
  for (const auto& DelPair : Reporter.getDeclarationList())
    Results.insert(DelPair);
  EXPECT_EQ(ExpectedDeclarations, Results);
}

} // namespace
} // namespce move
} // namespace clang
