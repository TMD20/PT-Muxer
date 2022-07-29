// created by jay 0.7 (c) 1998 Axel.Schreiner@informatik.uni-osnabrueck.de

#line 2 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
//
// RELAX NG Compact Syntax parser
//
// Author:
//	Atsushi Enomoto <ginga@kit.hi-ho.ne.jp>
//
// (C)2003 Atsushi Enomoto
//
// Copyright (c) 2004 Novell Inc.
// All rights reserved
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Xml;
using Commons.Xml.Relaxng;

namespace Commons.Xml.Relaxng.Rnc
{

	public class RncParser
	{
		public static RelaxngPattern ParseRnc (TextReader reader)
		{
			return ParseRnc (reader, new NameTable ());
		}

		public static RelaxngPattern ParseRnc (TextReader reader, XmlNameTable nameTable)
		{
			return ParseRnc (reader, nameTable, null);
		}

		public static RelaxngPattern ParseRnc (TextReader reader, XmlNameTable nameTable, string baseUri)
		{
			return ParseRnc (reader, nameTable, baseUri, null);
		}

		public static RelaxngPattern ParseRnc (TextReader reader, XmlNameTable nameTable, string baseUri, string defaultNamespace)
		{
			return new RncParser (nameTable).Parse (reader, baseUri, defaultNamespace);
		}

		XmlNamespaceManager nsmgr;
		XmlNamespaceManager dtnsmgr;
		string defaultNamespace;
		static int yacc_verbose_flag;

		RncTokenizer tokenizer;

		public RncParser (XmlNameTable nameTable)
		{
			if (nameTable == null)
				nameTable = new NameTable ();
			nsmgr = new XmlNamespaceManager (nameTable);
			dtnsmgr = new XmlNamespaceManager (nameTable);
			dtnsmgr.AddNamespace ("xsd", "http://www.w3.org/2001/XMLSchema-datatypes");
			ErrorOutput = System.IO.TextWriter.Null;
		}

		public int Line {
			get { return tokenizer.Line; }
		}

		public int Column {
			get { return tokenizer.Column; }
		}

		public string BaseUri {
			get { return tokenizer.BaseUri; }
		}

		// note that this is different notion than that of xmlns.

		public RelaxngPattern Parse (TextReader source)
		{
			return Parse (source, null);
		}

		public RelaxngPattern Parse (TextReader source, string baseUri)
		{
			return Parse (source, baseUri, null);
		}

		public RelaxngPattern Parse (TextReader source, string baseUri, string defaultNamespace)
		{
			this.defaultNamespace = defaultNamespace ?? string.Empty;
			if (defaultNamespace != null && defaultNamespace.Length != 0)
				nsmgr.AddNamespace (String.Empty, defaultNamespace);
			try {
				if (Environment.GetEnvironmentVariable ("MONO_RELAXNG_COMPACT_DEBUG") == "yes")
					debug = new yydebug.yyDebugSimple ();
				tokenizer = new RncTokenizer (source, baseUri);
				RelaxngPattern p = (RelaxngPattern) yyparse (tokenizer);
				if (p is RelaxngGrammar)
					((RelaxngGrammar) p).IsSourceCompactSyntax = true;
				return p;
			} catch (Exception ex) {
				throw new RelaxngException (String.Format ("Tokenizer error at line {0}, column {1}: {2}", Line, Column, ex.Message), ex);
			}
		}

		private void FillLocation (RelaxngElementBase el)
		{
			el.BaseUri = BaseUri;
			el.LineNumber = Line;
			el.LinePosition = Column;
		}

		private void FillGrammarContent (IList source, IList starts, IList defines, IList divs, IList includes)
		{
			foreach (RelaxngElementBase elem in source) {
				if (elem is RelaxngStart)
					starts.Add (elem);
				else if (elem is RelaxngDefine)
					defines.Add (elem);
				else if (elem is RelaxngDiv)
					divs.Add (elem);
				else if (elem is RelaxngInclude)
					includes.Add (elem);
				else
					throw new InvalidOperationException ();
			}
		}

		private XmlQualifiedName SplitQName (XmlNamespaceManager nsmgr, string name)
		{
			int colon = name.IndexOf (':');
			if (colon < 0)
				return new XmlQualifiedName (name, String.Empty);
			string local = name.Substring (colon + 1);
			string prefix = name.Substring (0, colon);
			return new XmlQualifiedName (local, nsmgr.LookupNamespace (nsmgr.NameTable.Get (prefix)));
		}

		private void FillElementDefaultNS (RelaxngNameClass nc)
		{
			RelaxngName name = nc as RelaxngName;
			if (name != null) {
				if (name.Namespace == null)
					name.Namespace = defaultNamespace;
				return;
			}
			RelaxngNameChoice choice = nc as RelaxngNameChoice;
			if (choice != null) {
				foreach (RelaxngNameClass c in choice.Children)
					FillElementDefaultNS (c);
			}
		}

		private void FillAttributeDefaultNS (RelaxngNameClass nc)
		{
			RelaxngName name = nc as RelaxngName;
			if (name != null) {
				if (name.Namespace == null)
					name.Namespace = String.Empty;
				return;
			}
			RelaxngNameChoice choice = nc as RelaxngNameChoice;
			if (choice != null) {
				foreach (RelaxngNameClass c in choice.Children)
					FillAttributeDefaultNS (c);
			}
		}

#line default

  /** error output stream.
      It should be changeable.
    */
  public System.IO.TextWriter ErrorOutput = System.Console.Out;

  /** simplified error message.
      @see <a href="#yyerror(java.lang.String, java.lang.String[])">yyerror</a>
    */
  public void yyerror (string message) {
    yyerror(message, null);
  }
#pragma warning disable 649
  /* An EOF token */
  public int eof_token;
#pragma warning restore 649
  /** (syntax) error message.
      Can be overwritten to control message format.
      @param message text to be displayed.
      @param expected vector of acceptable tokens, if available.
    */
  public void yyerror (string message, string[] expected) {
    if ((yacc_verbose_flag > 0) && (expected != null) && (expected.Length  > 0)) {
      ErrorOutput.Write (message+", expecting");
      for (int n = 0; n < expected.Length; ++ n)
        ErrorOutput.Write (" "+expected[n]);
        ErrorOutput.WriteLine ();
    } else
      ErrorOutput.WriteLine (message);
  }

  /** debugging support, requires the package jay.yydebug.
      Set to null to suppress debugging messages.
    */
  internal yydebug.yyDebug debug;

  protected const int yyFinal = 4;
 // Put this array into a separate class so it is only initialized if debugging is actually used
 // Use MarshalByRefObject to disable inlining
 class YYRules : MarshalByRefObject {
  public static readonly string [] yyRule = {
    "$accept : TopLevel",
    "TopLevel : Preamble TopLevelBody",
    "Preamble :",
    "Preamble : Decl Preamble",
    "Decl : KeywordNamespace NamespacePrefix Equal NamespaceURILiteral",
    "Decl : KeywordDefault KeywordNamespace Equal NamespaceURILiteral",
    "Decl : KeywordDefault KeywordNamespace NamespacePrefix Equal NamespaceURILiteral",
    "Decl : KeywordDatatypes DatatypePrefix Equal Literal",
    "NamespacePrefix : IdentifierOrKeyword",
    "DatatypePrefix : IdentifierOrKeyword",
    "NamespaceURILiteral : Literal",
    "NamespaceURILiteral : KeywordInherit",
    "TopLevelBody : Pattern",
    "TopLevelBody : Grammar",
    "Grammar :",
    "Grammar : Member Grammar",
    "Member : AnnotatedComponent",
    "Member : AnnotationElementNotKeyword",
    "AnnotatedComponent : Annotations Component",
    "Component : Start",
    "Component : Define",
    "Component : Include",
    "Component : Div",
    "Start : KeywordStart AssignOp Pattern",
    "Define : Identifier AssignOp Pattern",
    "AssignOp : Equal",
    "AssignOp : OrEquals",
    "AssignOp : AndEquals",
    "Include : KeywordInclude AnyURILiteral OptInherit OptIncludeBody",
    "AnyURILiteral : Literal",
    "OptInherit :",
    "OptInherit : KeywordInherit Equal IdentifierOrKeyword",
    "OptIncludeBody :",
    "OptIncludeBody : OpenCurly IncludeBody CloseCurly",
    "IncludeBody :",
    "IncludeBody : IncludeMember IncludeBody",
    "IncludeMember : AnnotatedIncludeComponent",
    "IncludeMember : AnnotationElementNotKeyword",
    "AnnotatedIncludeComponent : Annotations IncludeComponent",
    "IncludeComponent : Start",
    "IncludeComponent : Define",
    "IncludeComponent : IncludeDiv",
    "Div : KeywordDiv OpenCurly Grammar CloseCurly",
    "IncludeDiv : KeywordDiv OpenCurly IncludeBody CloseCurly",
    "Pattern : InnerPattern",
    "InnerPattern : InnerParticle",
    "InnerPattern : ParticleChoice",
    "InnerPattern : ParticleGroup",
    "InnerPattern : ParticleInterleave",
    "InnerPattern : AnnotatedDataExcept",
    "ParticleChoice : Particle Bar Particle",
    "ParticleChoice : Particle Bar ParticleChoice",
    "ParticleGroup : Particle Comma Particle",
    "ParticleGroup : Particle Comma ParticleGroup",
    "ParticleInterleave : Particle Amp Particle",
    "ParticleInterleave : Particle Amp ParticleInterleave",
    "Particle : InnerParticle",
    "InnerParticle : AnnotatedPrimary",
    "InnerParticle : RepeatedPrimary FollowAnnotations",
    "RepeatedPrimary : AnnotatedPrimary Asterisk",
    "RepeatedPrimary : AnnotatedPrimary Plus",
    "RepeatedPrimary : AnnotatedPrimary Question",
    "AnnotatedPrimary : LeadAnnotatedPrimary FollowAnnotations",
    "AnnotatedDataExcept : LeadAnnotatedDataExcept FollowAnnotations",
    "LeadAnnotatedDataExcept : Annotations DataExcept",
    "LeadAnnotatedPrimary : Annotations Primary",
    "LeadAnnotatedPrimary : Annotations OpenParen InnerPattern CloseParen",
    "Primary : KeywordElement NameClass OpenCurly Pattern CloseCurly",
    "Primary : KeywordAttribute NameClass OpenCurly Pattern CloseCurly",
    "Primary : KeywordMixed OpenCurly Pattern CloseCurly",
    "Primary : KeywordList OpenCurly Pattern CloseCurly",
    "Primary : DatatypeName OptParams",
    "Primary : DatatypeName DatatypeValue",
    "Primary : DatatypeValue",
    "Primary : KeywordEmpty",
    "Primary : KeywordNotAllowed",
    "Primary : KeywordText",
    "Primary : Ref",
    "Primary : KeywordParent Ref",
    "Primary : KeywordGrammar OpenCurly Grammar CloseCurly",
    "Primary : KeywordExternal AnyURILiteral OptInherit",
    "DataExcept : DatatypeName OptParams Minus LeadAnnotatedPrimary",
    "Ref : Identifier",
    "DatatypeName : CName",
    "DatatypeName : KeywordString",
    "DatatypeName : KeywordToken",
    "DatatypeValue : Literal",
    "OptParams :",
    "OptParams : OpenCurly Params CloseCurly",
    "Params :",
    "Params : Param Params",
    "Param : Annotations IdentifierOrKeyword Equal Literal",
    "NameClass : InnerNameClass",
    "InnerNameClass : AnnotatedSimpleNameClass",
    "InnerNameClass : NameClassChoice",
    "InnerNameClass : AnnotatedExceptNameClass",
    "NameClassChoice : AnnotatedSimpleNameClass Bar AnnotatedSimpleNameClass",
    "NameClassChoice : AnnotatedSimpleNameClass Bar NameClassChoice",
    "AnnotatedExceptNameClass : LeadAnnotatedExceptNameClass FollowAnnotations",
    "LeadAnnotatedExceptNameClass : Annotations ExceptNameClass",
    "AnnotatedSimpleNameClass : LeadAnnotatedSimpleNameClass FollowAnnotations",
    "LeadAnnotatedSimpleNameClass : Annotations SimpleNameClass",
    "LeadAnnotatedSimpleNameClass : Annotations OpenParen InnerNameClass CloseParen",
    "ExceptNameClass : NsName Minus LeadAnnotatedSimpleNameClass",
    "ExceptNameClass : Asterisk Minus LeadAnnotatedSimpleNameClass",
    "SimpleNameClass : IdentifierOrKeyword",
    "SimpleNameClass : CName",
    "SimpleNameClass : NsName",
    "SimpleNameClass : Asterisk",
    "FollowAnnotations :",
    "FollowAnnotations : TwoGreaters AnnotationElement FollowAnnotations",
    "Annotations : Documentations",
    "Annotations : Documentations OpenBracket AnnotationContentInAnnotations CloseBracket",
    "AnnotationContentInAnnotations :",
    "AnnotationContentInAnnotations : PrefixedName Equal Literal AnnotationContentInAnnotations",
    "AnnotationContentInAnnotations : PrefixedName AnnotationAttributesContent AnnotationContentInAnnotations",
    "AnnotationContentInAnnotations : IdentifierOrKeyword AnnotationAttributesContent AnnotationContentInAnnotations",
    "AttributableAnnotations :",
    "AttributableAnnotations : AttributableAnnotations PrefixedName Equal Literal NonAttributableAnnotations",
    "NonAttributableAnnotations :",
    "NonAttributableAnnotations : PrefixedName AnnotationAttributesContent",
    "NonAttributableAnnotations : NonAttributableAnnotations IdentifierOrKeyword AnnotationAttributesContent",
    "AnnotationElement : ForeignElementName AnnotationAttributesContent",
    "ForeignElementName : IdentifierOrKeyword",
    "ForeignElementName : PrefixedName",
    "AnnotationElementNotKeyword : ERROR",
    "AnnotationAttributesContent : OpenBracket NestedAnnotationContents CloseBracket",
    "NestedAnnotationContents :",
    "NestedAnnotationContents : PrefixedName Equal Literal NestedAnnotationContents",
    "NestedAnnotationContents : IdentifierOrKeyword Equal Literal NestedAnnotationContents",
    "NestedAnnotationContents : PrefixedName AnnotationAttributesContent NestedAnnotationContents",
    "NestedAnnotationContents : IdentifierOrKeyword AnnotationAttributesContent NestedAnnotationContents",
    "NestedAnnotationContents : Literal",
    "NestedAnnotationContents : Literal NestedAnnotationContents",
    "NestedAnnotationAttributes :",
    "NestedAnnotationAttributes : AnyAttributeName Equal Literal NestedAnnotationAttributes",
    "AnyAttributeName : IdentifierOrKeyword",
    "AnyAttributeName : PrefixedName",
    "AnnotationContent :",
    "AnnotationContent : NestedAnnotationElement AnnotationContent",
    "AnnotationContent : Literal AnnotationContent",
    "NestedAnnotationElement : AnyElementName AnnotationAttributesContent",
    "AnyElementName : IdentifierOrKeyword",
    "AnyElementName : PrefixedName",
    "PrefixedName : CName",
    "Documentations :",
    "Documentations : Documentation Documentations",
    "IdentifierOrKeyword : Identifier",
    "IdentifierOrKeyword : Keyword",
    "Keyword : KeywordAttribute",
    "Keyword : KeywordDefault",
    "Keyword : KeywordDatatypes",
    "Keyword : KeywordDiv",
    "Keyword : KeywordElement",
    "Keyword : KeywordEmpty",
    "Keyword : KeywordExternal",
    "Keyword : KeywordGrammar",
    "Keyword : KeywordInclude",
    "Keyword : KeywordInherit",
    "Keyword : KeywordList",
    "Keyword : KeywordMixed",
    "Keyword : KeywordNamespace",
    "Keyword : KeywordNotAllowed",
    "Keyword : KeywordParent",
    "Keyword : KeywordStart",
    "Keyword : KeywordString",
    "Keyword : KeywordText",
    "Keyword : KeywordToken",
    "Literal : LiteralSegment",
    "Literal : LiteralSegment Tilde Literal",
    "Identifier : NCName",
    "Identifier : QuotedIdentifier",
  };
 public static string getRule (int index) {
    return yyRule [index];
 }
}
  protected static readonly string [] yyNames = {    
    "end-of-file",null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,"'&'",
    null,"'('","')'","'*'","'+'","','","'-'",null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,"'='",null,"'?'",
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,
    "'['",null,"']'",null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,"'{'","'|'","'}'","'~'",null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    "ERROR","EOF","KeywordAttribute","\"attribute\"","KeywordDefault",
    "KeywordDatatypes","\"datatypes\"","KeywordDiv","\"div\"",
    "KeywordElement","\"element\"","KeywordEmpty","\"empty\"",
    "KeywordExternal","\"external\"","KeywordGrammar","\"grammar\"",
    "KeywordInclude","\"include\"","KeywordInherit","\"inherit\"",
    "KeywordList","\"list\"","KeywordMixed","\"mixed\"",
    "KeywordNamespace","KeywordNotAllowed","\"notAllowed\"",
    "KeywordParent","\"parent\"","KeywordStart","\"start\"",
    "KeywordString","KeywordText","\"text\"","KeywordToken","\"left\"",
    "Equal","Comma","Tilde","OpenCurly","CloseCurly","OpenParen",
    "CloseParen","OpenBracket","CloseBracket","Amp","Bar","Question",
    "Asterisk","Plus","Minus","OrEquals","\"|=\"","AndEquals","\"&=\"",
    "TwoGreaters","\">>\"","LiteralSegment","NCName","QuotedIdentifier",
    "Documentation","CName","NsName",
  };

  /** index-checked interface to yyNames[].
      @param token single character or %token value.
      @return token name or [illegal] or [unknown].
    */
  public static string yyname (int token) {
    if ((token < 0) || (token > yyNames.Length)) return "[illegal]";
    string name;
    if ((name = yyNames[token]) != null) return name;
    return "[unknown]";
  }

#pragma warning disable 414
  int yyExpectingState;
#pragma warning restore 414
  /** computes list of expected tokens on error by tracing the tables.
      @param state for which to compute the list.
      @return list of token names.
    */
  protected int [] yyExpectingTokens (int state){
    int token, n, len = 0;
    bool[] ok = new bool[yyNames.Length];
    if ((n = yySindex[state]) != 0)
      for (token = n < 0 ? -n : 0;
           (token < yyNames.Length) && (n+token < yyTable.Length); ++ token)
        if (yyCheck[n+token] == token && !ok[token] && yyNames[token] != null) {
          ++ len;
          ok[token] = true;
        }
    if ((n = yyRindex[state]) != 0)
      for (token = n < 0 ? -n : 0;
           (token < yyNames.Length) && (n+token < yyTable.Length); ++ token)
        if (yyCheck[n+token] == token && !ok[token] && yyNames[token] != null) {
          ++ len;
          ok[token] = true;
        }
    int [] result = new int [len];
    for (n = token = 0; n < len;  ++ token)
      if (ok[token]) result[n++] = token;
    return result;
  }
  protected string[] yyExpecting (int state) {
    int [] tokens = yyExpectingTokens (state);
    string [] result = new string[tokens.Length];
    for (int n = 0; n < tokens.Length;  n++)
      result[n++] = yyNames[tokens [n]];
    return result;
  }

  /** the generated parser, with debugging messages.
      Maintains a state and a value stack, currently with fixed maximum size.
      @param yyLex scanner.
      @param yydebug debug message writer implementing yyDebug, or null.
      @return result of the last reduction, if any.
      @throws yyException on irrecoverable parse error.
    */
  internal Object yyparse (yyParser.yyInput yyLex, Object yyd)
				 {
    this.debug = (yydebug.yyDebug)yyd;
    return yyparse(yyLex);
  }

  /** initial size and increment of the state/value stack [default 256].
      This is not final so that it can be overwritten outside of invocations
      of yyparse().
    */
  protected int yyMax;

  /** executed at the beginning of a reduce action.
      Used as $$ = yyDefault($1), prior to the user-specified action, if any.
      Can be overwritten to provide deep copy, etc.
      @param first value for $1, or null.
      @return first.
    */
  protected Object yyDefault (Object first) {
    return first;
  }

	static int[] global_yyStates;
	static object[] global_yyVals;
#pragma warning disable 649
	protected bool use_global_stacks;
#pragma warning restore 649
	object[] yyVals;					// value stack
	object yyVal;						// value stack ptr
	int yyToken;						// current input
	int yyTop;

  /** the generated parser.
      Maintains a state and a value stack, currently with fixed maximum size.
      @param yyLex scanner.
      @return result of the last reduction, if any.
      @throws yyException on irrecoverable parse error.
    */
  internal Object yyparse (yyParser.yyInput yyLex)
  {
    if (yyMax <= 0) yyMax = 256;		// initial size
    int yyState = 0;                   // state stack ptr
    int [] yyStates;               	// state stack 
    yyVal = null;
    yyToken = -1;
    int yyErrorFlag = 0;				// #tks to shift
	if (use_global_stacks && global_yyStates != null) {
		yyVals = global_yyVals;
		yyStates = global_yyStates;
   } else {
		yyVals = new object [yyMax];
		yyStates = new int [yyMax];
		if (use_global_stacks) {
			global_yyVals = yyVals;
			global_yyStates = yyStates;
		}
	}

    /*yyLoop:*/ for (yyTop = 0;; ++ yyTop) {
      if (yyTop >= yyStates.Length) {			// dynamically increase
        global::System.Array.Resize (ref yyStates, yyStates.Length+yyMax);
        global::System.Array.Resize (ref yyVals, yyVals.Length+yyMax);
      }
      yyStates[yyTop] = yyState;
      yyVals[yyTop] = yyVal;
      if (debug != null) debug.push(yyState, yyVal);

      /*yyDiscarded:*/ while (true) {	// discarding a token does not change stack
        int yyN;
        if ((yyN = yyDefRed[yyState]) == 0) {	// else [default] reduce (yyN)
          if (yyToken < 0) {
            yyToken = yyLex.advance() ? yyLex.token() : 0;
            if (debug != null)
              debug.lex(yyState, yyToken, yyname(yyToken), yyLex.value());
          }
          if ((yyN = yySindex[yyState]) != 0 && ((yyN += yyToken) >= 0)
              && (yyN < yyTable.Length) && (yyCheck[yyN] == yyToken)) {
            if (debug != null)
              debug.shift(yyState, yyTable[yyN], yyErrorFlag-1);
            yyState = yyTable[yyN];		// shift to yyN
            yyVal = yyLex.value();
            yyToken = -1;
            if (yyErrorFlag > 0) -- yyErrorFlag;
            goto continue_yyLoop;
          }
          if ((yyN = yyRindex[yyState]) != 0 && (yyN += yyToken) >= 0
              && yyN < yyTable.Length && yyCheck[yyN] == yyToken)
            yyN = yyTable[yyN];			// reduce (yyN)
          else
            switch (yyErrorFlag) {
  
            case 0:
              yyExpectingState = yyState;
              // yyerror(String.Format ("syntax error, got token `{0}'", yyname (yyToken)), yyExpecting(yyState));
              if (debug != null) debug.error("syntax error");
              if (yyToken == 0 /*eof*/ || yyToken == eof_token) throw new yyParser.yyUnexpectedEof ();
              goto case 1;
            case 1: case 2:
              yyErrorFlag = 3;
              do {
                if ((yyN = yySindex[yyStates[yyTop]]) != 0
                    && (yyN += Token.yyErrorCode) >= 0 && yyN < yyTable.Length
                    && yyCheck[yyN] == Token.yyErrorCode) {
                  if (debug != null)
                    debug.shift(yyStates[yyTop], yyTable[yyN], 3);
                  yyState = yyTable[yyN];
                  yyVal = yyLex.value();
                  goto continue_yyLoop;
                }
                if (debug != null) debug.pop(yyStates[yyTop]);
              } while (-- yyTop >= 0);
              if (debug != null) debug.reject();
              throw new yyParser.yyException("irrecoverable syntax error");
  
            case 3:
              if (yyToken == 0) {
                if (debug != null) debug.reject();
                throw new yyParser.yyException("irrecoverable syntax error at end-of-file");
              }
              if (debug != null)
                debug.discard(yyState, yyToken, yyname(yyToken),
  							yyLex.value());
              yyToken = -1;
              goto continue_yyDiscarded;		// leave stack alone
            }
        }
        int yyV = yyTop + 1-yyLen[yyN];
        if (debug != null)
          debug.reduce(yyState, yyStates[yyV-1], yyN, YYRules.getRule (yyN), yyLen[yyN]);
        yyVal = yyV > yyTop ? null : yyVals[yyV]; // yyVal = yyDefault(yyV > yyTop ? null : yyVals[yyV]);
        switch (yyN) {
case 1:
#line 254 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngPattern) yyVals[0+yyTop];
	}
  break;
case 2:
#line 261 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 3:
#line 265 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 4:
  case_4();
  break;
case 5:
  case_5();
  break;
case 6:
  case_6();
  break;
case 7:
  case_7();
  break;
case 8:
#line 312 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
case 9:
#line 319 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
case 10:
#line 326 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
case 11:
#line 330 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = defaultNamespace;
	}
  break;
case 12:
  case_12();
  break;
case 13:
  case_13();
  break;
case 14:
#line 359 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new RelaxngGrammarContentList ();
	}
  break;
case 15:
  case_15();
  break;
case 16:
#line 373 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (IGrammarContent) yyVals[0+yyTop];
	}
  break;
case 17:
#line 377 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 18:
  case_18();
  break;
case 19:
#line 392 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngStart) yyVals[0+yyTop];
	}
  break;
case 20:
#line 396 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngDefine) yyVals[0+yyTop];
	}
  break;
case 21:
#line 400 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngInclude) yyVals[0+yyTop];
	}
  break;
case 22:
#line 404 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngDiv) yyVals[0+yyTop];
	}
  break;
case 23:
  case_23();
  break;
case 24:
  case_24();
  break;
case 25:
#line 434 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 26:
#line 438 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = "choice";
	}
  break;
case 27:
#line 442 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = "interleave";
	}
  break;
case 28:
  case_28();
  break;
case 29:
  case_29();
  break;
case 30:
  case_30();
  break;
case 31:
  case_31();
  break;
case 32:
#line 484 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new ArrayList ();
	}
  break;
case 33:
#line 488 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (IList) yyVals[-1+yyTop];
	}
  break;
case 34:
#line 495 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new ArrayList ();
	}
  break;
case 35:
  case_35();
  break;
case 36:
#line 508 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngElementBase) yyVals[0+yyTop];
	}
  break;
case 37:
#line 512 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngElementBase) yyVals[0+yyTop];
	}
  break;
case 38:
  case_38();
  break;
case 39:
#line 527 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngStart) yyVals[0+yyTop];
	}
  break;
case 40:
#line 531 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngDefine) yyVals[0+yyTop];
	}
  break;
case 41:
#line 535 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngDiv) yyVals[0+yyTop];
	}
  break;
case 42:
  case_42();
  break;
case 43:
  case_43();
  break;
case 45:
#line 567 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngPattern) yyVals[0+yyTop];
	}
  break;
case 46:
  case_46();
  break;
case 47:
  case_47();
  break;
case 48:
  case_48();
  break;
case 49:
#line 601 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngData) yyVals[0+yyTop];
	}
  break;
case 50:
  case_50();
  break;
case 51:
  case_51();
  break;
case 52:
  case_52();
  break;
case 53:
  case_53();
  break;
case 54:
  case_54();
  break;
case 55:
  case_55();
  break;
case 57:
  case_57();
  break;
case 58:
  case_58();
  break;
case 59:
  case_59();
  break;
case 60:
  case_60();
  break;
case 61:
  case_61();
  break;
case 62:
  case_62();
  break;
case 63:
  case_63();
  break;
case 64:
#line 717 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = yyVals[0+yyTop];
	}
  break;
case 65:
  case_65();
  break;
case 66:
  case_66();
  break;
case 67:
  case_67();
  break;
case 68:
  case_68();
  break;
case 69:
  case_69();
  break;
case 70:
  case_70();
  break;
case 71:
  case_71();
  break;
case 72:
  case_72();
  break;
case 73:
  case_73();
  break;
case 74:
  case_74();
  break;
case 75:
  case_75();
  break;
case 76:
  case_76();
  break;
case 77:
  case_77();
  break;
case 78:
  case_78();
  break;
case 79:
  case_79();
  break;
case 80:
  case_80();
  break;
case 81:
  case_81();
  break;
case 83:
  case_83();
  break;
case 84:
#line 887 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new XmlQualifiedName ("string", String.Empty);
	}
  break;
case 85:
#line 891 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new XmlQualifiedName ("token", String.Empty);
	}
  break;
case 87:
#line 902 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new RelaxngParamList ();
	}
  break;
case 88:
#line 906 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = yyVals[-1+yyTop];
	}
  break;
case 89:
#line 913 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new RelaxngParamList ();
	}
  break;
case 90:
  case_90();
  break;
case 91:
  case_91();
  break;
case 92:
#line 939 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = yyVals[0+yyTop];
	}
  break;
case 93:
#line 946 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngNameClass) yyVals[0+yyTop];
	}
  break;
case 94:
  case_94();
  break;
case 95:
#line 959 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngNameClass) yyVals[0+yyTop];
	}
  break;
case 96:
  case_96();
  break;
case 97:
  case_97();
  break;
case 98:
#line 982 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngNameClass) yyVals[-1+yyTop];
	}
  break;
case 99:
#line 989 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (RelaxngNameClass) yyVals[0+yyTop];
	}
  break;
case 100:
  case_100();
  break;
case 101:
  case_101();
  break;
case 102:
#line 1009 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = yyVals[-1+yyTop];
	}
  break;
case 103:
  case_103();
  break;
case 104:
  case_104();
  break;
case 105:
  case_105();
  break;
case 106:
  case_106();
  break;
case 107:
  case_107();
  break;
case 108:
  case_108();
  break;
case 109:
#line 1072 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 110:
  case_110();
  break;
case 111:
#line 1085 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 112:
#line 1089 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 122:
  case_122();
  break;
case 123:
#line 1127 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new XmlQualifiedName ((string) yyVals[0+yyTop], String.Empty);
	}
  break;
case 126:
#line 1163 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 134:
#line 1181 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 135:
  case_135();
  break;
case 136:
#line 1195 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new XmlQualifiedName ((string) yyVals[0+yyTop]);
	}
  break;
case 137:
  case_137();
  break;
case 138:
#line 1207 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 139:
#line 1211 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 140:
#line 1215 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 141:
  case_141();
  break;
case 142:
#line 1231 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = new XmlQualifiedName ((string) yyVals[0+yyTop], String.Empty);
	}
  break;
case 143:
#line 1235 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (XmlQualifiedName) yyVals[0+yyTop];
	}
  break;
case 144:
  case_144();
  break;
case 145:
#line 1250 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = null;
	}
  break;
case 146:
  case_146();
  break;
case 147:
#line 1263 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
case 148:
#line 1267 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
case 168:
#line 1296 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
case 169:
#line 1300 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[-2+yyTop] + (string) yyVals[0+yyTop];
	}
  break;
case 170:
#line 1307 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
case 171:
#line 1311 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
  {
		yyVal = (string) yyVals[0+yyTop];
	}
  break;
#line default
        }
        yyTop -= yyLen[yyN];
        yyState = yyStates[yyTop];
        int yyM = yyLhs[yyN];
        if (yyState == 0 && yyM == 0) {
          if (debug != null) debug.shift(0, yyFinal);
          yyState = yyFinal;
          if (yyToken < 0) {
            yyToken = yyLex.advance() ? yyLex.token() : 0;
            if (debug != null)
               debug.lex(yyState, yyToken,yyname(yyToken), yyLex.value());
          }
          if (yyToken == 0) {
            if (debug != null) debug.accept(yyVal);
            return yyVal;
          }
          goto continue_yyLoop;
        }
        if (((yyN = yyGindex[yyM]) != 0) && ((yyN += yyState) >= 0)
            && (yyN < yyTable.Length) && (yyCheck[yyN] == yyState))
          yyState = yyTable[yyN];
        else
          yyState = yyDgoto[yyM];
        if (debug != null) debug.shift(yyStates[yyTop], yyState);
	 goto continue_yyLoop;
      continue_yyDiscarded: ;	// implements the named-loop continue: 'continue yyDiscarded'
      }
    continue_yyLoop: ;		// implements the named-loop continue: 'continue yyLoop'
    }
  }

/*
 All more than 3 lines long rules are wrapped into a method
*/
void case_4()
#line 270 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* TODO: constraints*/
		string prefix = (string) yyVals[-2+yyTop];
		string ns = (string) yyVals[0+yyTop];
		if (prefix == "local")
			nsmgr.AddNamespace (String.Empty, ns);
		else
			nsmgr.AddNamespace (prefix, ns);
		yyVal = null;
	}

void case_5()
#line 281 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* TODO: constraints*/
		string ns = (string) yyVals[0+yyTop];
		defaultNamespace = ns;
		nsmgr.AddNamespace (String.Empty, ns);
		yyVal = null;
	}

void case_6()
#line 289 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* TODO: constraints*/
		string prefix = (string) yyVals[-2+yyTop];
		string ns = (string) yyVals[0+yyTop];
		defaultNamespace = ns;
		nsmgr.AddNamespace (String.Empty, ns);
		nsmgr.AddNamespace (prefix, ns);
		yyVal = null;
	}

void case_7()
#line 299 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* TODO: constraints*/
		string prefix = (string) yyVals[-2+yyTop];
		string ns = (string) yyVals[0+yyTop];
		dtnsmgr.AddNamespace (prefix, ns);
		yyVal = null;
	}

void case_12()
#line 335 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* TODO: Constraint: single element*/
/*		IList pl = (IList) $1;*/
/*		if (pl.Count != 1)*/
/*			throw new RelaxngException ("The number of the top level pattern must be exactly one.");*/
/*		$$ = pl [0];*/
		yyVal = (RelaxngPattern) yyVals[0+yyTop];
	}

void case_13()
#line 344 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngGrammar g = new RelaxngGrammar ();
		FillLocation (g);
		if (defaultNamespace != null)
			g.DefaultNamespace = defaultNamespace;
		RelaxngGrammarContentList list = (RelaxngGrammarContentList) yyVals[0+yyTop];
		FillGrammarContent (list, g.Starts, g.Defines, g.Divs, g.Includes);
		yyVal = g;
	}

void case_15()
#line 361 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngGrammarContentList al = (RelaxngGrammarContentList) yyVals[0+yyTop];
		if (yyVals[-1+yyTop] != null)
			al.Insert (0, (IGrammarContent) yyVals[-1+yyTop]);
		yyVal = al;
	}

void case_18()
#line 382 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
/*		$$ = ApplyAnnotations ((string) $1, (RelaxngElementBase) $2);*/
		yyVal = (IGrammarContent) yyVals[0+yyTop];
	}

void case_23()
#line 409 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngStart start = new RelaxngStart ();
		FillLocation (start);
		start.Combine = (string) yyVals[-1+yyTop];
		start.Pattern = (RelaxngPattern) yyVals[0+yyTop];
		yyVal = start;
	}

void case_24()
#line 420 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngDefine def = new RelaxngDefine ();
		FillLocation (def);
		def.Name = (string) yyVals[-2+yyTop];
		def.Combine = (string) yyVals[-1+yyTop];
		def.Patterns.Add ((RelaxngPattern) yyVals[0+yyTop]);
		yyVal = def;
	}

void case_28()
#line 447 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* FIXME: OptInherit is not handled properly.*/
		RelaxngInclude include = new RelaxngInclude ();
		FillLocation (include);
		include.Href = (string) yyVals[-2+yyTop];
		include.NSContext = (string) yyVals[-1+yyTop];
		FillGrammarContent ((IList) yyVals[0+yyTop], include.Starts, include.Defines, include.Divs, null);
		yyVal = include;
	}

void case_29()
#line 460 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* Constraints: any URI*/
		yyVal = (string) yyVals[0+yyTop];
	}

void case_30()
#line 469 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* MakeNsAttribute (LookupDefault (environment));*/
		yyVal = defaultNamespace;
	}

void case_31()
#line 474 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* MakeNsAttribute (LookupPrefix (environment, $3));*/
		yyVal = nsmgr.LookupPrefix ((string) yyVals[0+yyTop]);
	}

void case_35()
#line 497 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		ArrayList al = (ArrayList) yyVals[0+yyTop];
		al.Insert (0, yyVals[-1+yyTop]);
		yyVal = al;
	}

void case_38()
#line 517 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
/*		$$ = ApplyAnnotations ((string) $1, (RelaxngElementBase) $2);*/
		yyVal = (IGrammarContent) yyVals[0+yyTop];
	}

void case_42()
#line 540 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngDiv div = new RelaxngDiv ();
		FillLocation (div);
		FillGrammarContent ((IList) yyVals[-1+yyTop], div.Starts, div.Defines, div.Divs, div.Includes);
		yyVal = div;
	}

void case_43()
#line 550 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngDiv div = new RelaxngDiv ();
		FillLocation (div);
		FillGrammarContent ((IList) yyVals[-1+yyTop], div.Starts, div.Defines, div.Divs, div.Includes);
		yyVal = div;
	}

void case_46()
#line 569 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = (RelaxngPatternList) yyVals[0+yyTop];
		RelaxngChoice choice = new RelaxngChoice ();
		FillLocation (choice);
		for (int i = 0; i < list.Count; i++)
			choice.Patterns.Add (list [i]);
		/* This is said as to return Elements, while ApplyAnnotations() is said to return Element*/
		yyVal = choice;
	}

void case_47()
#line 579 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = (RelaxngPatternList) yyVals[0+yyTop];
		RelaxngGroup group = new RelaxngGroup ();
		FillLocation (group);
		for (int i = 0; i < list.Count; i++)
			group.Patterns.Add (list [i]);
		/* This is said as to return Elements, while ApplyAnnotations() is said to return Element*/
		yyVal = group;
	}

void case_48()
#line 589 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = (RelaxngPatternList) yyVals[0+yyTop];
		RelaxngInterleave interleave = new RelaxngInterleave ();
		FillLocation (interleave);
		for (int i = 0; i < list.Count; i++)
			interleave.Patterns.Add (list [i]);
		/* This is said as to return Elements, while ApplyAnnotations() is said to return Element*/
		yyVal = interleave;
	}

void case_50()
#line 606 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = new RelaxngPatternList ();
		list.Add ((RelaxngPattern) yyVals[-2+yyTop]);
		list.Add ((RelaxngPattern) yyVals[0+yyTop]);
		yyVal = list;
	}

void case_51()
#line 613 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = (RelaxngPatternList) yyVals[0+yyTop];
		list.Insert (0, (RelaxngPattern) yyVals[-2+yyTop]);
		yyVal = list;
	}

void case_52()
#line 622 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = new RelaxngPatternList ();
		list.Add ((RelaxngPattern) yyVals[-2+yyTop]);
		list.Add ((RelaxngPattern) yyVals[0+yyTop]);
		yyVal = list;
	}

void case_53()
#line 629 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = (RelaxngPatternList) yyVals[0+yyTop];
		list.Insert (0, (RelaxngPattern) yyVals[-2+yyTop]);
		yyVal = list;
	}

void case_54()
#line 638 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = new RelaxngPatternList ();
		list.Add ((RelaxngPattern) yyVals[-2+yyTop]);
		list.Add ((RelaxngPattern) yyVals[0+yyTop]);
		yyVal = list;
	}

void case_55()
#line 645 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngPatternList list = (RelaxngPatternList) yyVals[0+yyTop];
		list.Insert (0, (RelaxngPattern) yyVals[-2+yyTop]);
		yyVal = list;
	}

void case_57()
#line 658 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
/*		$$ = ApplyAnnotationsGroup (null, (RelaxngPatternList) $1);*/
		yyVal = yyVals[0+yyTop];
	}

void case_58()
#line 663 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* FIXME: annotations are not handled*/
		RelaxngPattern p = (RelaxngPattern) yyVals[-1+yyTop];
/*		RelaxngPatternList l = new RelaxngPatternList ();*/
/*		l.Add (p);*/
/*		$$ = l;*/
		yyVal = p;
	}

void case_59()
#line 675 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngZeroOrMore zom = new RelaxngZeroOrMore ();
		FillLocation (zom);
		zom.Patterns.Add ((RelaxngPattern) yyVals[-1+yyTop]);
		yyVal = zom;
	}

void case_60()
#line 682 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngOneOrMore oom = new RelaxngOneOrMore ();
		FillLocation (oom);
		oom.Patterns.Add ((RelaxngPattern) yyVals[-1+yyTop]);
		yyVal = oom;
	}

void case_61()
#line 689 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngOptional opt = new RelaxngOptional ();
		FillLocation (opt);
		opt.Patterns.Add ((RelaxngPattern) yyVals[-1+yyTop]);
		yyVal = opt;
	}

void case_62()
#line 699 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* FIXME: handle followAnnotations*/
		yyVal = yyVals[-1+yyTop];
	}

void case_63()
#line 707 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* FIXME: handle followAnnotations*/
		yyVal = yyVals[-1+yyTop];
	}

void case_65()
#line 722 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* LAMESPEC: This should return Elements, while ApplyAnnotations() returns Element*/
/*		RelaxngPatternList list = new RelaxngPatternList ();*/
/*		list.Add ((RelaxngPattern) ApplyAnnotations ((string) $1, (RelaxngPattern) $2));*/
/*		$$ = list;*/
		yyVal = (RelaxngPattern) yyVals[0+yyTop];
	}

void case_66()
#line 730 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
/*		$$ = (RelaxngPatternList) $3;*/
		yyVal = (RelaxngPattern) yyVals[-1+yyTop];
	}

void case_67()
#line 738 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNameClass nc = (RelaxngNameClass) yyVals[-3+yyTop];
		RelaxngElement el = new RelaxngElement ();
		FillLocation (el);
		el.NameClass = nc;
		FillElementDefaultNS (el.NameClass);
		el.Patterns.Add ((RelaxngPattern) yyVals[-1+yyTop]);
		yyVal = el;
	}

void case_68()
#line 748 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNameClass nc = (RelaxngNameClass) yyVals[-3+yyTop];

		RelaxngAttribute attr = new RelaxngAttribute ();
		FillLocation (attr);
		attr.NameClass = nc;
		FillAttributeDefaultNS (attr.NameClass);
		attr.Pattern = (RelaxngPattern) yyVals[-1+yyTop];
		yyVal = attr;
	}

void case_69()
#line 759 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngMixed mixed = new RelaxngMixed ();
		FillLocation (mixed);
		mixed.Patterns.Add ((RelaxngPattern) yyVals[-1+yyTop]);
		yyVal = mixed;
	}

void case_70()
#line 766 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngList list = new RelaxngList ();
		FillLocation (list);
		list.Patterns.Add ((RelaxngPattern) yyVals[-1+yyTop]);
		yyVal = list;
	}

void case_71()
#line 773 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngData data = new RelaxngData ();
		FillLocation (data);
		XmlQualifiedName dtName = (XmlQualifiedName) yyVals[-1+yyTop];
		data.DatatypeLibrary = dtName.Namespace;
		data.Type = dtName.Name;
		foreach (RelaxngParam p in (ICollection) yyVals[0+yyTop])
			data.ParamList.Add (p);

		yyVal = data;
	}

void case_72()
#line 785 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngValue value = new RelaxngValue ();
		FillLocation (value);
		XmlQualifiedName dtName = (XmlQualifiedName) yyVals[-1+yyTop];
		if (dtName.Namespace != RelaxngGrammar.NamespaceURI)
			value.DatatypeLibrary = dtName.Namespace;
		value.Type = dtName.Name;
		value.Value = (string) yyVals[0+yyTop];

		yyVal = value;
	}

void case_73()
#line 797 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngValue value = new RelaxngValue ();
		FillLocation (value);
		value.Value = (string) yyVals[0+yyTop];

		/* RELAX NG default type*/
		value.Type = "string";
		value.DatatypeLibrary = String.Empty;

		yyVal = value;
	}

void case_74()
#line 809 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngEmpty empty = new RelaxngEmpty ();
		FillLocation (empty);
		yyVal = empty;
	}

void case_75()
#line 815 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNotAllowed na = new RelaxngNotAllowed ();
		FillLocation (na);
		yyVal = na;
	}

void case_76()
#line 821 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngText text = new RelaxngText ();
		FillLocation (text);
		yyVal = text;
	}

void case_77()
#line 827 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngRef r = new RelaxngRef ();
		FillLocation (r);
		r.Name = (string) yyVals[0+yyTop];
		yyVal = r;
	}

void case_78()
#line 834 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngParentRef pref = new RelaxngParentRef ();
		FillLocation (pref);
		pref.Name = (string) yyVals[0+yyTop];
		yyVal = pref;
	}

void case_79()
#line 841 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngGrammar g = new RelaxngGrammar ();
		FillLocation (g);
		FillGrammarContent ((IList) yyVals[-1+yyTop], g.Starts, g.Defines, g.Divs, g.Includes);
		yyVal = g;
	}

void case_80()
#line 848 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngExternalRef extref = new RelaxngExternalRef ();
		FillLocation (extref);
		extref.Href = (string) yyVals[-1+yyTop];
		extref.NSContext = (string) yyVals[0+yyTop];
		yyVal = extref;
	}

void case_81()
#line 859 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		XmlQualifiedName type = (XmlQualifiedName) yyVals[-3+yyTop];
		RelaxngData data = new RelaxngData ();
		FillLocation (data);
		data.Type = type.Name;
		data.DatatypeLibrary = type.Namespace;
		foreach (RelaxngParam p in (RelaxngParamList) yyVals[-2+yyTop])
			data.ParamList.Add (p);
		data.Except = new RelaxngExcept ();
		FillLocation (data.Except);
		data.Except.Patterns.Add ((RelaxngPattern) yyVals[0+yyTop]);
		yyVal = data;
	}

void case_83()
#line 880 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		string cname = (string) yyVals[0+yyTop];
		yyVal = SplitQName (dtnsmgr, cname);
	}

void case_90()
#line 915 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngParamList al = (RelaxngParamList) yyVals[0+yyTop];
		al.Insert (0, (RelaxngParam) yyVals[-1+yyTop]);
		yyVal = al;
	}

void case_91()
#line 924 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngParam prm = new RelaxngParam ();
		FillLocation (prm);
		prm.Name = (string) yyVals[-2+yyTop];
		prm.Value = (string) yyVals[0+yyTop];

/*		$$ = ApplyAnnotations ((string) $1, prm);*/
		yyVal = prm;
	}

void case_94()
#line 948 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNameChoice cho = new RelaxngNameChoice ();
		FillLocation (cho);
		RelaxngNameClassList list = (RelaxngNameClassList) yyVals[0+yyTop];
		for (int i = 0; i < list.Count; i++)
			cho.Children.Add ((RelaxngNameClass) list [i]);
		yyVal = cho;
	}

void case_96()
#line 964 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNameClassList list = new RelaxngNameClassList ();
		list.Add ((RelaxngNameClass) yyVals[-2+yyTop]);
		list.Add ((RelaxngNameClass) yyVals[0+yyTop]);
		yyVal = list;
	}

void case_97()
#line 971 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNameClassList list = (RelaxngNameClassList) yyVals[0+yyTop];
		list.Insert (0, (RelaxngNameClass) yyVals[-2+yyTop]);
		yyVal = list;
	}

void case_100()
#line 994 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* FIXME: annotations*/
		yyVal = yyVals[-1+yyTop];
	}

void case_101()
#line 1002 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* FIXME: applyAnnotations*/
		yyVal = (RelaxngNameClass) yyVals[0+yyTop];
	}

void case_103()
#line 1014 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNsName nsName = new RelaxngNsName ();
		FillLocation (nsName);
		nsName.Namespace = nsmgr.LookupNamespace ((string) yyVals[-2+yyTop]);
		nsName.Except = new RelaxngExceptNameClass ();
		FillLocation (nsName.Except);
		nsName.Except.Names.Add ((RelaxngNameClass) yyVals[0+yyTop]);
		yyVal = nsName;
	}

void case_104()
#line 1024 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngAnyName anyName = new RelaxngAnyName ();
		FillLocation (anyName);
		anyName.Except = new RelaxngExceptNameClass ();
		FillLocation (anyName.Except);
		anyName.Except.Names.Add ((RelaxngNameClass) yyVals[0+yyTop]);
		yyVal = anyName;
	}

void case_105()
#line 1036 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngName name = new RelaxngName ();
		FillLocation (name);
		name.LocalName = (string) yyVals[0+yyTop];
		name.Namespace = null;
		yyVal = name;
	}

void case_106()
#line 1044 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		string cname = (string) yyVals[0+yyTop];
		XmlQualifiedName qname = SplitQName (nsmgr, cname);
		RelaxngName name = new RelaxngName ();
		FillLocation (name);
		name.LocalName = qname.Name;
		name.Namespace = qname.Namespace;
		yyVal = name;
	}

void case_107()
#line 1054 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngNsName nsName = new RelaxngNsName ();
		FillLocation (nsName);
		nsName.Namespace = nsmgr.LookupNamespace ((string) yyVals[0+yyTop]);
		yyVal = nsName;
	}

void case_108()
#line 1061 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		RelaxngAnyName anyName= new RelaxngAnyName ();
		FillLocation (anyName);
		yyVal = anyName;
	}

void case_110()
#line 1074 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* FIXME: handle them*/
		yyVal = null;
	}

void case_122()
#line 1116 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* do nothing*/
/*		$$ = Element ($1, $2);*/
		yyVal = null;
	}

void case_135()
#line 1183 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* Constraint: duplicate attributes*/

		/* do nothing*/
/*		$$ = Attribute ($1, $2);*/
		yyVal = null;
	}

void case_137()
#line 1197 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* Constraint: xmlns namespace URI*/
		yyVal = (XmlQualifiedName) yyVals[0+yyTop];
	}

void case_141()
#line 1220 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* do nothing*/
/*		$$ = Element ($1, $2);*/
		yyVal = null;
	}

void case_144()
#line 1240 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* Constraint: annotation inherit*/
		yyVal = SplitQName (nsmgr, (string) yyVals[0+yyTop]);
	}

void case_146()
#line 1252 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
{
		/* do nothing*/
/*		$$ = Element (DocumentationElementName (), Text ((string) $1), $2);*/
		yyVal = null;
	}

#line default
   static readonly short [] yyLhs  = {              -1,
    0,    1,    1,    3,    3,    3,    3,    4,    6,    5,
    5,    2,    2,   10,   10,   11,   11,   12,   15,   15,
   15,   15,   16,   17,   20,   20,   20,   18,   22,   23,
   23,   24,   24,   25,   25,   26,   26,   27,   28,   28,
   28,   19,   29,    9,   30,   30,   30,   30,   30,   32,
   32,   33,   33,   34,   34,   36,   31,   31,   38,   38,
   38,   37,   35,   41,   40,   40,   43,   43,   43,   43,
   43,   43,   43,   43,   43,   43,   43,   43,   43,   43,
   42,   48,   45,   45,   45,   47,   46,   46,   49,   49,
   50,   44,   51,   51,   51,   53,   53,   54,   55,   52,
   57,   57,   56,   56,   58,   58,   58,   58,   39,   39,
   14,   14,   61,   61,   61,   61,   64,   64,   65,   65,
   65,   59,   66,   66,   13,   63,   67,   67,   67,   67,
   67,   67,   67,   68,   68,   69,   69,   70,   70,   70,
   71,   72,   72,   62,   60,   60,    8,    8,   73,   73,
   73,   73,   73,   73,   73,   73,   73,   73,   73,   73,
   73,   73,   73,   73,   73,   73,   73,    7,    7,   21,
   21,
  };
   static readonly short [] yyLen = {           2,
    2,    0,    2,    4,    4,    5,    4,    1,    1,    1,
    1,    1,    1,    0,    2,    1,    1,    2,    1,    1,
    1,    1,    3,    3,    1,    1,    1,    4,    1,    0,
    3,    0,    3,    0,    2,    1,    1,    2,    1,    1,
    1,    4,    4,    1,    1,    1,    1,    1,    1,    3,
    3,    3,    3,    3,    3,    1,    1,    2,    2,    2,
    2,    2,    2,    2,    2,    4,    5,    5,    4,    4,
    2,    2,    1,    1,    1,    1,    1,    2,    4,    3,
    4,    1,    1,    1,    1,    1,    0,    3,    0,    2,
    4,    1,    1,    1,    1,    3,    3,    2,    2,    2,
    2,    4,    3,    3,    1,    1,    1,    1,    0,    3,
    1,    4,    0,    4,    3,    3,    0,    5,    0,    2,
    3,    2,    1,    1,    1,    3,    0,    4,    4,    3,
    3,    1,    2,    0,    4,    1,    1,    0,    2,    2,
    2,    1,    1,    1,    0,    2,    1,    1,    1,    1,
    1,    1,    1,    1,    1,    1,    1,    1,    1,    1,
    1,    1,    1,    1,    1,    1,    1,    1,    3,    1,
    1,
  };
   static readonly short [] yyDefRed = {            0,
    0,    0,    0,    0,    0,    0,    0,  149,  150,  151,
  152,  153,  154,  155,  156,  157,  158,  159,  160,  161,
  162,  163,  164,  165,  166,  167,  170,  171,    0,    9,
  147,  148,    0,    8,  125,    0,    1,   12,   13,    0,
   16,   17,    0,   44,    0,   46,   47,   48,   49,    0,
    0,    0,    0,    0,    0,    3,    0,    0,    0,    0,
  146,   15,    0,    0,    0,    0,   74,    0,    0,    0,
    0,    0,   75,    0,    0,   84,   76,   85,    0,    0,
   83,   86,   18,   19,   20,   21,   22,    0,   64,   65,
    0,   73,   77,    0,    0,    0,   61,   59,   60,    0,
   58,   62,   63,    0,   11,    5,   10,    0,    7,    4,
    0,    0,    0,   92,    0,   94,   95,    0,    0,    0,
    0,   29,    0,    0,    0,    0,    0,   82,   78,   25,
   26,   27,    0,    0,    0,    0,    0,    0,    0,   72,
    0,   56,   53,    0,   55,    0,   51,    0,  144,  123,
    0,  124,    0,    0,    0,    0,    6,    0,    0,  106,
    0,  105,   99,  101,    0,    0,   98,  100,    0,    0,
    0,   80,    0,    0,    0,    0,   23,   66,  169,   24,
    0,    0,    0,    0,    0,  110,    0,  122,    0,  112,
    0,    0,    0,    0,    0,    0,    0,    0,   97,   42,
    0,    0,   79,    0,   28,   70,   69,    0,   88,   90,
   81,   71,    0,    0,    0,    0,  116,    0,  115,  102,
  104,  103,   68,  108,  107,   67,   31,   37,    0,    0,
    0,   36,    0,  133,    0,    0,    0,    0,  126,  114,
    0,   39,   40,   38,   41,   33,   35,   91,    0,  131,
    0,  130,    0,  129,  128,    0,   43,
  };
  protected static readonly short [] yyDgoto  = {             4,
    5,   37,    6,   33,  106,   29,  213,  214,   38,   39,
   40,   41,   42,  134,   83,   84,   85,   86,   87,  137,
   31,  123,  172,  205,  230,  231,  232,  244,  245,   44,
   45,   46,   47,   48,   49,   50,   51,   52,  101,   53,
   54,   89,   90,  113,   91,  139,   92,   93,  182,  183,
  114,  115,  116,  117,  118,  163,  119,  164,  151,   55,
  155,  215,  188,    0,    0,  153,  216,    0,    0,    0,
    0,    0,   32,
  };
  protected static readonly short [] yySindex = {         -231,
 -255, 1296, 1296,    0, -241, -231, 1237,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0, -251,    0,
    0,    0, -245,    0,    0, -286,    0,    0,    0, -241,
    0,    0, 1025,    0,    0,    0,    0,    0,    0, -167,
 -156, -254, -254, -254, -232,    0, -262, -222, -227, -262,
    0,    0, -183, -286, -198, -286,    0, -227, -186, -227,
 -181, -173,    0, -203, -272,    0,    0,    0, -286, -153,
    0,    0,    0,    0,    0,    0,    0, -272,    0,    0,
 -277,    0,    0, -286, -286, -286,    0,    0,    0,  990,
    0,    0,    0,  990,    0,    0,    0, -262,    0,    0,
 -272,  807, -151,    0, -157,    0,    0, -254, -254, -241,
 -135,    0, -118, -241, -118, -286, -286,    0,    0,    0,
    0,    0, -286, 1119, -137, -227, -286, -286, -143,    0,
 1119,    0,    0, -129,    0, -128,    0, -127,    0,    0,
 -254,    0, -125, -125, -124, -236,    0, -286, -126,    0,
 -121,    0,    0,    0, -286, -286,    0,    0, -119, -286,
 -114,    0, -115, -109, -108, -107,    0,    0,    0,    0,
 1296, -105, -286, -286, -277,    0,  931,    0,  990,    0,
 -227,  990, -106, -286, -286,  -99,  869, -157,    0,    0,
  -97, 1296,    0, -241,    0,    0,    0,  -96,    0,    0,
    0,    0,  931, -216, -199,  -98,    0,  990,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0, -164,  -95,
 -241,    0, -227,    0, -227,  931, -227,  931,    0,    0,
  -90,    0,    0,    0,    0,    0,    0,    0,  931,    0,
  931,    0, -241,    0,    0,  -88,    0,
  };
  protected static readonly short [] yyRindex = {           64,
    0,    0,    0,    0,  125,   64,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,  621,    0,    0,    0,   61,
    0,    0,    0,    0,  372,    0,    0,    0,    0,    0,
  400,  428,  337,  450,  683,    0,    0,    0,    0,    0,
    0,    0,    0,  745,    0,  745,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0, 1067,    1,
    0,    0,    0,    0,    0,    0,    0,   63,    0,    0,
  156,    0,    0, 1067, 1067, 1067,    0,    0,    0,    0,
    0,    0,    0,  -87,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0, -271,    0,    0, -252, -217, -246,
    0,    0,  181, -246,  478, 1067, 1067,    0,    0,    0,
    0,    0, 1067,    0,    0,    0, 1067, 1178,  226,    0,
    0,    0,    0,  506,    0,  514,    0,  553,    0,    0,
  251,    0,    0,    0,    0,    0,    0,  745, -165,    0,
 -159,    0,    0,    0, 1067,  745,    0,    0,    0, 1067,
    0,    0,    0,  561,    0,    0,    0,    0,    0,    0,
    0,    0, 1178, 1067,  309,    0,  -86,    0,  -87,    0,
    0,  -87,    0,  745,  745,    0,    0, -243,    0,    0,
    0,    0,    0, -208,    0,    0,    0,    0,    0,    0,
    0,    0,  -86,    0,    0,    0,    0,  -87,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
 -208,    0,    0,    0,    0,  -86,    0,  -86,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,  -86,    0,
  -86,    0, -208,    0,    0,    0,    0,
  };
  protected static readonly short [] yyGindex = {            0,
  196,    0,    0,  201,  -48,    0,  -24,    3,   -6,  -38,
    0,    0, -191,    2,    0,  -17,  -15,    0,    0,  142,
  -40,  148,   94,    0, -206,    0,    0,    0,    0,  141,
   75,  126,  129,  130,    0,   78,    0,    0,  -45,   40,
    0,    0,    0,  161,   87,   44,  -80,  157,   47,    0,
   74,   68,   69,    0,    0,    0,  -65,    0,    0,  200,
 -168, -100, -139,    0,    0,    0,  -94,    0,    0,    0,
    0,    0,    0,
  };
  protected static readonly short [] yyTable = {           152,
  168,   62,   88,  156,   30,   34,   43,  102,  103,   34,
  140,  110,  228,  105,  189,   35,  192,  145,   82,  138,
  217,  130,  111,  219,  247,   93,    7,  145,   93,    1,
    2,   36,  107,  128,  109,  107,  131,   80,  132,  228,
  145,   63,   59,  122,  109,  122,  256,  109,   60,  240,
    3,   14,   80,   96,  145,  145,   96,  191,  100,  157,
   14,  228,   82,    2,  187,  112,   82,  112,  104,  145,
  145,  108,  167,  168,  236,  238,   36,  235,  145,  109,
   65,  169,  109,  107,  187,  173,  109,   80,  156,   34,
   70,  156,  145,  128,  237,  141,  141,  141,  120,  241,
  128,  187,  150,   75,  140,  186,  154,  145,  145,   82,
  124,  179,   27,   28,  162,  126,   82,  156,  234,  175,
  176,   63,   75,  127,   14,   63,  177,   94,  221,  222,
  180,  108,   27,   28,  108,   95,   96,  107,  108,  181,
  107,  250,  136,  252,  107,  165,  166,  108,   97,   98,
   99,   27,   28,  107,  254,   87,  255,  171,  196,  112,
   82,  170,  178,  201,  184,   94,  218,  197,  142,  142,
  142,  144,  146,  148,   95,  187,   96,  190,  200,  202,
   30,  194,  203,  208,  181,  141,  195,  204,  111,  206,
  207,  154,  209,  220,  154,  197,  197,  233,  223,  162,
  226,   56,  246,  239,  227,  229,  253,   58,  248,  257,
  249,  242,  251,  243,  113,  127,  133,  125,  174,  135,
  154,  147,  143,  211,  145,   71,  121,  185,  212,  210,
  129,  193,  229,  198,  199,   61,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
  109,    0,    0,    0,  229,    0,    0,  168,    0,  168,
    0,  168,  168,    0,  168,    0,  168,    0,  168,    0,
  168,    0,  168,    0,  168,    0,  168,    0,  168,    0,
  168,    0,  168,  168,    0,  168,    0,  168,    0,  168,
  168,    0,  168,    0,    0,  168,    0,  168,  168,  168,
  168,  168,  168,  168,  168,  168,  168,  168,   87,    0,
    0,    0,    0,  168,    0,  168,  168,  168,  168,  168,
    2,    0,    2,    0,  145,    0,    0,    2,    0,    2,
    0,    2,    0,    2,  145,    2,  109,    2,    0,    0,
    0,    2,    0,    2,    0,    0,    2,  145,    2,    0,
    2,    0,    2,    2,    0,    2,    0,   82,   14,    0,
    0,  145,    2,    0,    2,   82,   82,   82,   82,   82,
    0,   45,    0,    0,    0,   82,  145,  145,    2,    2,
    2,    2,    2,  145,    0,    0,    0,    0,  145,    0,
  145,    0,  145,    0,  145,    0,  145,    0,  145,   57,
    0,    0,  145,    0,  145,    0,    0,  145,    0,  145,
    0,  145,   87,  145,  145,    0,  145,    0,    0,   87,
    0,    0,    0,  145,    0,  145,    0,  109,    0,   87,
    0,    0,    0,    0,    0,    0,    0,   30,    0,  145,
  145,  145,   87,  145,   30,    0,    0,    0,    0,  109,
   87,    0,    0,   87,   30,   87,   87,    0,   87,   87,
   87,   87,   87,   87,    0,    0,    0,   30,   87,    0,
    0,   87,   87,   87,    0,   30,    0,   30,   30,    0,
   30,   30,   71,   30,   30,   30,   30,   30,    0,   71,
    0,    0,    0,   30,    0,    0,   30,   30,   30,   71,
    0,    0,    0,    0,    0,   52,    0,  109,    0,    0,
    0,    0,   71,   54,  109,    0,    0,    0,    0,    0,
   71,    0,    0,   71,  109,   71,   71,    0,   71,   71,
   71,   71,   71,    0,    0,    0,    0,  109,   71,    0,
    0,   71,   71,   71,    0,  109,    0,  109,  109,    0,
  109,  109,   50,  109,  109,  109,  109,  109,    0,    0,
   32,    0,    0,    0,    0,   87,  109,  109,  109,    0,
    0,    0,   87,    0,    0,    0,    0,    0,    0,    0,
    0,    0,   87,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,  109,    0,   87,    0,    0,    0,    0,
  109,    0,    0,   87,    0,    0,   87,    0,   87,   87,
  109,   87,   87,   87,   87,   87,    0,    0,    0,    0,
    0,   87,    0,  109,   87,   87,   87,    0,   45,    0,
    0,  109,    0,    0,  109,   45,  109,  109,    0,  109,
  109,  109,  109,  109,    0,   45,    0,    0,    0,    0,
    0,    0,  109,  109,  109,    0,   57,    0,   45,    0,
    0,    0,    0,   57,    0,    0,   56,    0,    0,   45,
    0,   45,   45,   57,   56,   56,    0,    0,    0,    0,
    0,    0,    0,    0,  109,    0,   57,   45,   45,   45,
    0,  109,    0,    0,   57,    0,    0,   57,    0,   57,
   57,  109,   57,   57,    0,    0,  109,    0,    0,    0,
    0,    0,    0,  109,  109,   57,   57,   57,    0,    0,
    0,    0,  109,  109,    0,  109,    0,  109,  109,    0,
  109,  109,    0,    0,   30,    0,  109,    0,    0,    0,
    0,   30,    0,  109,  109,  109,    0,  109,    0,  109,
  109,   30,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,   52,    0,   30,  109,  109,  109,    0,   52,
   54,    0,    0,    0,   30,   30,    0,   54,   30,   52,
    0,    0,    0,    0,    0,    0,    0,   54,    0,    0,
    0,    0,   52,   30,   30,   30,    0,    0,    0,    0,
   54,    0,    0,   52,    0,   52,   52,    0,    0,   50,
    0,   54,    0,   54,   54,    0,   50,   32,    0,    0,
    0,   52,   52,   52,   32,    0,   50,    0,    0,   54,
   54,   54,    0,    0,   32,    0,    0,    0,    0,   50,
    0,    0,    0,    0,    0,    0,    0,   32,    0,    0,
   50,    0,   50,   50,    0,    0,    0,    0,   32,    0,
    0,   32,    0,    0,    0,    0,    0,    0,   50,   50,
   50,    0,    0,    0,    0,    0,   32,   32,   32,  145,
    0,  145,  145,    0,  145,    0,  145,    0,  145,    0,
  145,    0,  145,    0,  145,    0,  145,    0,  145,    0,
  145,    0,  145,  145,    0,  145,    0,  145,    0,  145,
  145,    0,  145,    0,    0,    0,    0,    0,    0,  145,
    0,  145,    0,    0,    0,    0,  145,    0,    0,    0,
    0,    0,    0,    0,    0,  145,  145,  145,    0,  145,
  145,  111,    0,  111,  111,    0,  111,    0,  111,    0,
  111,    0,  111,    0,  111,    0,  111,    0,  111,    0,
  111,    0,  111,    0,  111,  111,    0,  111,    0,  111,
    0,  111,  111,    0,  111,    0,    0,    0,    0,    0,
    0,  111,    0,    0,    0,    0,    0,    0,  111,    0,
    0,    0,    0,    0,    0,    0,    0,  111,  111,  111,
    0,  111,  111,  145,    0,  145,  145,    0,  145,    0,
  145,    0,  145,    0,  145,    0,  145,    0,  145,    0,
  145,    0,  145,    0,  145,    0,  145,  145,    0,  145,
    0,  145,    0,  145,  145,    0,  145,    0,    0,    0,
    0,    0,    0,  145,    0,  145,    0,    0,    0,    0,
  145,    0,    0,    0,    0,    0,    0,    0,    0,    0,
  145,  145,    0,  145,  145,    8,    0,    9,   10,    0,
   11,    0,   12,    0,   13,    0,   14,    0,   15,    0,
   16,    0,   17,    0,   18,    0,   19,    0,   20,   21,
    0,   22,    0,   23,    0,   24,   25,    0,   26,    0,
    0,    0,    0,    0,    0,  158,    0,    0,    0,    0,
    0,    0,  159,    0,    0,    0,    0,    0,    0,    0,
    0,    0,   27,   28,    0,  160,  161,    8,    0,    9,
   10,    0,   11,    0,   12,    0,   13,    0,   14,    0,
   15,    0,   16,    0,   17,    0,   18,    0,   19,    0,
   20,   21,    0,   22,    0,   23,    0,   24,   25,    0,
   26,    0,    0,    0,    0,    0,    0,  158,    0,    0,
    0,    0,    0,    0,  224,    0,    0,    0,    0,    0,
    0,    0,    0,    0,   27,   28,    0,  160,  225,    8,
    0,    9,   10,    0,   11,    0,   12,    0,   13,    0,
   14,    0,   15,    0,   16,    0,   17,    0,   18,    0,
   19,    0,   20,   21,    0,   22,    0,   23,    0,   24,
   25,    0,   26,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,   80,   27,   28,    8,  149,
    9,   10,    0,   11,    0,   12,    0,   13,    0,   14,
    0,   15,    0,   16,    0,   17,    0,   18,    0,   19,
    0,   20,   21,    0,   22,    0,   23,    0,   24,   25,
    0,   26,    0,   64,    0,    0,    0,    0,   65,    0,
   66,    0,   67,    0,   68,    0,   69,    0,   70,    0,
    0,    0,   71,    0,   72,   27,   28,   73,  149,   74,
    0,   75,    0,   76,   77,    0,   78,    0,    0,    0,
    0,    0,    0,   79,    0,  145,    0,    0,    0,    0,
    0,    0,  145,    0,  145,    0,  145,    0,  145,   80,
   27,   28,    0,   81,  145,    0,  145,    0,    0,  145,
    0,  145,    0,    0,    0,  145,  145,    0,  145,    0,
    0,    0,    0,    0,    0,  145,    0,  145,    0,    0,
    0,    0,    0,    0,    0,    0,    0,   64,    0,    0,
    0,  145,  145,  145,   66,  145,   67,    0,   68,    0,
   69,    0,    0,    0,    0,    0,   71,    0,   72,    0,
    0,   73,    0,   74,    0,    0,    0,   76,   77,    0,
   78,    0,    0,    0,    0,    0,    0,   79,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,   80,   27,   28,  145,   81,  145,  145,
    0,  145,    0,  145,    0,  145,    0,  145,    0,  145,
    0,  145,    0,  145,    0,  145,    0,  145,    0,  145,
  145,    0,  145,    0,  145,    0,  145,  145,    0,  145,
    0,    0,    0,    0,    0,   89,    0,    0,  145,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,  145,  145,    8,    0,    9,   10,    0,
   11,    0,   12,    0,   13,    0,   14,    0,   15,    0,
   16,    0,   17,    0,   18,    0,   19,    0,   20,   21,
    0,   22,    0,   23,    0,   24,   25,    0,   26,    0,
   57,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,   27,   28,    8,    0,    9,   10,    0,   11,
    0,   12,    0,   13,    0,   14,    0,   15,    0,   16,
    0,   17,    0,   18,    0,   19,    0,   20,   21,    0,
   22,    0,   23,    0,   24,   25,    0,   26,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,   27,   28,
  };
  protected static readonly short [] yyCheck = {           100,
    0,   40,   43,  104,    2,    3,    5,   53,   54,    7,
   91,   60,  204,  276,  154,  257,  156,  264,   43,  297,
  189,  294,   63,  192,  231,  297,  282,  274,  300,  261,
  262,  318,   57,   74,   59,   60,  309,  315,  311,  231,
  287,   40,  294,   68,  297,   70,  253,  300,  294,  218,
  282,  298,  315,  297,  301,  264,  300,  294,  313,  108,
    0,  253,    0,    0,  301,   64,   91,   66,  301,  316,
  317,  294,  118,  119,  214,  215,  318,  294,  287,  297,
  264,  120,  300,  108,  301,  124,  304,  315,  189,  298,
  274,  192,  301,  134,  294,   94,   95,   96,  297,  264,
  141,  301,  100,  287,  185,  151,  104,  316,  317,  134,
  297,  136,  316,  317,  112,  297,  141,  218,  213,  126,
  127,  120,  287,  297,    0,  124,  133,  295,  194,  195,
  137,  297,  316,  317,  300,  303,  304,  297,  304,  138,
  300,  236,  296,  238,  304,  297,  304,  313,  305,  306,
  307,  316,  317,  313,  249,    0,  251,  276,  165,  158,
  185,  297,  300,  170,  308,  295,  191,  166,   94,   95,
   96,   94,   95,   96,  303,  301,  304,  302,  298,  294,
    0,  308,  298,  181,  183,  184,  308,  297,  229,  298,
  298,  189,  298,  300,  192,  194,  195,  294,  298,  197,
  298,    6,  298,  302,  202,  204,  297,    7,  233,  298,
  235,  229,  237,  229,  302,  302,   75,   70,  125,   79,
  218,   96,   94,  184,   95,    0,   66,  141,  185,  183,
   74,  158,  231,  166,  166,   36,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
    0,   -1,   -1,   -1,  253,   -1,   -1,  257,   -1,  259,
   -1,  261,  262,   -1,  264,   -1,  266,   -1,  268,   -1,
  270,   -1,  272,   -1,  274,   -1,  276,   -1,  278,   -1,
  280,   -1,  282,  283,   -1,  285,   -1,  287,   -1,  289,
  290,   -1,  292,   -1,   -1,  295,   -1,  297,  298,  299,
  300,  301,  302,  303,  304,  305,  306,  307,    0,   -1,
   -1,   -1,   -1,  313,   -1,  315,  316,  317,  318,  319,
  257,   -1,  259,   -1,  264,   -1,   -1,  264,   -1,  266,
   -1,  268,   -1,  270,  274,  272,    0,  274,   -1,   -1,
   -1,  278,   -1,  280,   -1,   -1,  283,  287,  285,   -1,
  287,   -1,  289,  290,   -1,  292,   -1,  295,  298,   -1,
   -1,  301,  299,   -1,  301,  303,  304,  305,  306,  307,
   -1,    0,   -1,   -1,   -1,  313,  316,  317,  315,  316,
  317,  318,  319,  259,   -1,   -1,   -1,   -1,  264,   -1,
  266,   -1,  268,   -1,  270,   -1,  272,   -1,  274,    0,
   -1,   -1,  278,   -1,  280,   -1,   -1,  283,   -1,  285,
   -1,  287,  257,  289,  290,   -1,  292,   -1,   -1,  264,
   -1,   -1,   -1,  299,   -1,  301,   -1,    0,   -1,  274,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,  257,   -1,  315,
  316,  317,  287,  319,  264,   -1,   -1,   -1,   -1,    0,
  295,   -1,   -1,  298,  274,  300,  301,   -1,  303,  304,
  305,  306,  307,  308,   -1,   -1,   -1,  287,  313,   -1,
   -1,  316,  317,  318,   -1,  295,   -1,    0,  298,   -1,
  300,  301,  257,  303,  304,  305,  306,  307,   -1,  264,
   -1,   -1,   -1,  313,   -1,   -1,  316,  317,  318,  274,
   -1,   -1,   -1,   -1,   -1,    0,   -1,  257,   -1,   -1,
   -1,   -1,  287,    0,  264,   -1,   -1,   -1,   -1,   -1,
  295,   -1,   -1,  298,  274,  300,  301,   -1,  303,  304,
  305,  306,  307,   -1,   -1,   -1,   -1,  287,  313,   -1,
   -1,  316,  317,  318,   -1,  295,   -1,  297,  298,   -1,
  300,  301,    0,  303,  304,  305,  306,  307,   -1,   -1,
    0,   -1,   -1,   -1,   -1,  257,  316,  317,  318,   -1,
   -1,   -1,  264,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,  274,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,  257,   -1,  287,   -1,   -1,   -1,   -1,
  264,   -1,   -1,  295,   -1,   -1,  298,   -1,  300,  301,
  274,  303,  304,  305,  306,  307,   -1,   -1,   -1,   -1,
   -1,  313,   -1,  287,  316,  317,  318,   -1,  257,   -1,
   -1,  295,   -1,   -1,  298,  264,  300,  301,   -1,  303,
  304,  305,  306,  307,   -1,  274,   -1,   -1,   -1,   -1,
   -1,   -1,  316,  317,  318,   -1,  257,   -1,  287,   -1,
   -1,   -1,   -1,  264,   -1,   -1,  295,   -1,   -1,  298,
   -1,  300,  301,  274,  303,  304,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,  257,   -1,  287,  316,  317,  318,
   -1,  264,   -1,   -1,  295,   -1,   -1,  298,   -1,  300,
  301,  274,  303,  304,   -1,   -1,  257,   -1,   -1,   -1,
   -1,   -1,   -1,  264,  287,  316,  317,  318,   -1,   -1,
   -1,   -1,  295,  274,   -1,  298,   -1,  300,  301,   -1,
  303,  304,   -1,   -1,  257,   -1,  287,   -1,   -1,   -1,
   -1,  264,   -1,  316,  317,  318,   -1,  298,   -1,  300,
  301,  274,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,  257,   -1,  287,  316,  317,  318,   -1,  264,
  257,   -1,   -1,   -1,  297,  298,   -1,  264,  301,  274,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,  274,   -1,   -1,
   -1,   -1,  287,  316,  317,  318,   -1,   -1,   -1,   -1,
  287,   -1,   -1,  298,   -1,  300,  301,   -1,   -1,  257,
   -1,  298,   -1,  300,  301,   -1,  264,  257,   -1,   -1,
   -1,  316,  317,  318,  264,   -1,  274,   -1,   -1,  316,
  317,  318,   -1,   -1,  274,   -1,   -1,   -1,   -1,  287,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,  287,   -1,   -1,
  298,   -1,  300,  301,   -1,   -1,   -1,   -1,  298,   -1,
   -1,  301,   -1,   -1,   -1,   -1,   -1,   -1,  316,  317,
  318,   -1,   -1,   -1,   -1,   -1,  316,  317,  318,  259,
   -1,  261,  262,   -1,  264,   -1,  266,   -1,  268,   -1,
  270,   -1,  272,   -1,  274,   -1,  276,   -1,  278,   -1,
  280,   -1,  282,  283,   -1,  285,   -1,  287,   -1,  289,
  290,   -1,  292,   -1,   -1,   -1,   -1,   -1,   -1,  299,
   -1,  301,   -1,   -1,   -1,   -1,  306,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,  315,  316,  317,   -1,  319,
  320,  259,   -1,  261,  262,   -1,  264,   -1,  266,   -1,
  268,   -1,  270,   -1,  272,   -1,  274,   -1,  276,   -1,
  278,   -1,  280,   -1,  282,  283,   -1,  285,   -1,  287,
   -1,  289,  290,   -1,  292,   -1,   -1,   -1,   -1,   -1,
   -1,  299,   -1,   -1,   -1,   -1,   -1,   -1,  306,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,  315,  316,  317,
   -1,  319,  320,  259,   -1,  261,  262,   -1,  264,   -1,
  266,   -1,  268,   -1,  270,   -1,  272,   -1,  274,   -1,
  276,   -1,  278,   -1,  280,   -1,  282,  283,   -1,  285,
   -1,  287,   -1,  289,  290,   -1,  292,   -1,   -1,   -1,
   -1,   -1,   -1,  299,   -1,  301,   -1,   -1,   -1,   -1,
  306,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
  316,  317,   -1,  319,  320,  259,   -1,  261,  262,   -1,
  264,   -1,  266,   -1,  268,   -1,  270,   -1,  272,   -1,
  274,   -1,  276,   -1,  278,   -1,  280,   -1,  282,  283,
   -1,  285,   -1,  287,   -1,  289,  290,   -1,  292,   -1,
   -1,   -1,   -1,   -1,   -1,  299,   -1,   -1,   -1,   -1,
   -1,   -1,  306,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,  316,  317,   -1,  319,  320,  259,   -1,  261,
  262,   -1,  264,   -1,  266,   -1,  268,   -1,  270,   -1,
  272,   -1,  274,   -1,  276,   -1,  278,   -1,  280,   -1,
  282,  283,   -1,  285,   -1,  287,   -1,  289,  290,   -1,
  292,   -1,   -1,   -1,   -1,   -1,   -1,  299,   -1,   -1,
   -1,   -1,   -1,   -1,  306,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,  316,  317,   -1,  319,  320,  259,
   -1,  261,  262,   -1,  264,   -1,  266,   -1,  268,   -1,
  270,   -1,  272,   -1,  274,   -1,  276,   -1,  278,   -1,
  280,   -1,  282,  283,   -1,  285,   -1,  287,   -1,  289,
  290,   -1,  292,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,  315,  316,  317,  259,  319,
  261,  262,   -1,  264,   -1,  266,   -1,  268,   -1,  270,
   -1,  272,   -1,  274,   -1,  276,   -1,  278,   -1,  280,
   -1,  282,  283,   -1,  285,   -1,  287,   -1,  289,  290,
   -1,  292,   -1,  259,   -1,   -1,   -1,   -1,  264,   -1,
  266,   -1,  268,   -1,  270,   -1,  272,   -1,  274,   -1,
   -1,   -1,  278,   -1,  280,  316,  317,  283,  319,  285,
   -1,  287,   -1,  289,  290,   -1,  292,   -1,   -1,   -1,
   -1,   -1,   -1,  299,   -1,  259,   -1,   -1,   -1,   -1,
   -1,   -1,  266,   -1,  268,   -1,  270,   -1,  272,  315,
  316,  317,   -1,  319,  278,   -1,  280,   -1,   -1,  283,
   -1,  285,   -1,   -1,   -1,  289,  290,   -1,  292,   -1,
   -1,   -1,   -1,   -1,   -1,  299,   -1,  301,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,  259,   -1,   -1,
   -1,  315,  316,  317,  266,  319,  268,   -1,  270,   -1,
  272,   -1,   -1,   -1,   -1,   -1,  278,   -1,  280,   -1,
   -1,  283,   -1,  285,   -1,   -1,   -1,  289,  290,   -1,
  292,   -1,   -1,   -1,   -1,   -1,   -1,  299,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,  315,  316,  317,  259,  319,  261,  262,
   -1,  264,   -1,  266,   -1,  268,   -1,  270,   -1,  272,
   -1,  274,   -1,  276,   -1,  278,   -1,  280,   -1,  282,
  283,   -1,  285,   -1,  287,   -1,  289,  290,   -1,  292,
   -1,   -1,   -1,   -1,   -1,  298,   -1,   -1,  301,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,  316,  317,  259,   -1,  261,  262,   -1,
  264,   -1,  266,   -1,  268,   -1,  270,   -1,  272,   -1,
  274,   -1,  276,   -1,  278,   -1,  280,   -1,  282,  283,
   -1,  285,   -1,  287,   -1,  289,  290,   -1,  292,   -1,
  294,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,  316,  317,  259,   -1,  261,  262,   -1,  264,
   -1,  266,   -1,  268,   -1,  270,   -1,  272,   -1,  274,
   -1,  276,   -1,  278,   -1,  280,   -1,  282,  283,   -1,
  285,   -1,  287,   -1,  289,  290,   -1,  292,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,  316,  317,
  };

#line 1315 "Commons.Xml.Relaxng.Rnc/RncParser.jay"
}
#line default
namespace yydebug {
        using System;
	 internal interface yyDebug {
		 void push (int state, Object value);
		 void lex (int state, int token, string name, Object value);
		 void shift (int from, int to, int errorFlag);
		 void pop (int state);
		 void discard (int state, int token, string name, Object value);
		 void reduce (int from, int to, int rule, string text, int len);
		 void shift (int from, int to);
		 void accept (Object value);
		 void error (string message);
		 void reject ();
	 }
	 
	 class yyDebugSimple : yyDebug {
		 void println (string s){
			 Console.Error.WriteLine (s);
		 }
		 
		 public void push (int state, Object value) {
			 println ("push\tstate "+state+"\tvalue "+value);
		 }
		 
		 public void lex (int state, int token, string name, Object value) {
			 println("lex\tstate "+state+"\treading "+name+"\tvalue "+value);
		 }
		 
		 public void shift (int from, int to, int errorFlag) {
			 switch (errorFlag) {
			 default:				// normally
				 println("shift\tfrom state "+from+" to "+to);
				 break;
			 case 0: case 1: case 2:		// in error recovery
				 println("shift\tfrom state "+from+" to "+to
					     +"\t"+errorFlag+" left to recover");
				 break;
			 case 3:				// normally
				 println("shift\tfrom state "+from+" to "+to+"\ton error");
				 break;
			 }
		 }
		 
		 public void pop (int state) {
			 println("pop\tstate "+state+"\ton error");
		 }
		 
		 public void discard (int state, int token, string name, Object value) {
			 println("discard\tstate "+state+"\ttoken "+name+"\tvalue "+value);
		 }
		 
		 public void reduce (int from, int to, int rule, string text, int len) {
			 println("reduce\tstate "+from+"\tuncover "+to
				     +"\trule ("+rule+") "+text);
		 }
		 
		 public void shift (int from, int to) {
			 println("goto\tfrom state "+from+" to "+to);
		 }
		 
		 public void accept (Object value) {
			 println("accept\tvalue "+value);
		 }
		 
		 public void error (string message) {
			 println("error\t"+message);
		 }
		 
		 public void reject () {
			 println("reject");
		 }
		 
	 }
}
// %token constants
 class Token {
  public const int ERROR = 257;
  public const int EOF = 258;
  public const int KeywordAttribute = 259;
  public const int attribute = 260;
  public const int KeywordDefault = 261;
  public const int KeywordDatatypes = 262;
  public const int datatypes = 263;
  public const int KeywordDiv = 264;
  public const int div = 265;
  public const int KeywordElement = 266;
  public const int element = 267;
  public const int KeywordEmpty = 268;
  public const int empty = 269;
  public const int KeywordExternal = 270;
  public const int external = 271;
  public const int KeywordGrammar = 272;
  public const int grammar = 273;
  public const int KeywordInclude = 274;
  public const int include = 275;
  public const int KeywordInherit = 276;
  public const int inherit = 277;
  public const int KeywordList = 278;
  public const int list = 279;
  public const int KeywordMixed = 280;
  public const int mixed = 281;
  public const int KeywordNamespace = 282;
  public const int KeywordNotAllowed = 283;
  public const int notAllowed = 284;
  public const int KeywordParent = 285;
  public const int parent = 286;
  public const int KeywordStart = 287;
  public const int start = 288;
  public const int KeywordString = 289;
  public const int KeywordText = 290;
  public const int text = 291;
  public const int KeywordToken = 292;
  public const int left = 293;
  public const int Equal = 294;
  public const int Comma = 295;
  public const int Tilde = 296;
  public const int OpenCurly = 297;
  public const int CloseCurly = 298;
  public const int OpenParen = 299;
  public const int CloseParen = 300;
  public const int OpenBracket = 301;
  public const int CloseBracket = 302;
  public const int Amp = 303;
  public const int Bar = 304;
  public const int Question = 305;
  public const int Asterisk = 306;
  public const int Plus = 307;
  public const int Minus = 308;
  public const int OrEquals = 309;
  public const int AndEquals = 311;
  public const int TwoGreaters = 313;
  public const int LiteralSegment = 315;
  public const int NCName = 316;
  public const int QuotedIdentifier = 317;
  public const int Documentation = 318;
  public const int CName = 319;
  public const int NsName = 320;
  public const int yyErrorCode = 256;
 }
 namespace yyParser {
  using System;
  /** thrown for irrecoverable syntax errors and stack overflow.
    */
  internal class yyException : System.Exception {
    public yyException (string message) : base (message) {
    }
  }
  internal class yyUnexpectedEof : yyException {
    public yyUnexpectedEof (string message) : base (message) {
    }
    public yyUnexpectedEof () : base ("") {
    }
  }

  /** must be implemented by a scanner object to supply input to the parser.
    */
  internal interface yyInput {
    /** move on to next token.
        @return false if positioned beyond tokens.
        @throws IOException on input error.
      */
    bool advance (); // throws java.io.IOException;
    /** classifies current token.
        Should not be called if advance() returned false.
        @return current %token or single character.
      */
    int token ();
    /** associated with current token.
        Should not be called if advance() returned false.
        @return value for token().
      */
    Object value ();
  }
 }
} // close outermost namespace, that MUST HAVE BEEN opened in the prolog
