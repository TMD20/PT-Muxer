// created by jay 0.7 (c) 1998 Axel.Schreiner@informatik.uni-osnabrueck.de

#line 29 "ExpressionParser.jay"

using System;
using System.Text;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Exceptions;
using Microsoft.Build.Framework;

/*

Pseudo formal syntax for .NET 4.0 expression:

Condition = Expression
Include = Expression*

 Expression
	BooleanLiteral
		TrueLiteral
		FalseLiteral
	BinaryExpression
		Expression "==" Expression
		Expression "!=" Expression
		Expression ">" Expression
		Expression ">=" Expression
		Expression "<" Expression
		Expression "<=" Expression
		Expression "And" Expression
		Expression "Or" Expression
	UnaryExpression
		"!" Expression
	PropertyExpression
		"$(" PropertyApplication ")"
	ItemExpression
		"@(" ItemApplication ")"
	MetadataBatchingExpression
		"%(" MetadataBatchingApplication ")"
  StringLiteralOrFunction
		StringLiteralOrFunctionName ( "(" FunctionArguments ")" )?

.NET error messages are so detailed which is something like "you forgot '(' after '$' ?" - so
it is likely that the MS tokenizer is hand-written.

*/

namespace Microsoft.Build.Internal.Expressions
{
	class ExpressionParser
	{
		static readonly int yacc_verbose_flag = Environment.GetEnvironmentVariable ("MONO_MSBUILD_PARSER_DEBUG") == "1" ? 1 : 0;

		object debug_obj = yacc_verbose_flag == 0 ? null : new yydebug.yyDebugSimple ();
		
		public ExpressionList Parse (string source, ExpressionValidationType validationType)
		{
			var tokenizer = new ExpressionTokenizer (source, validationType);
			return (ExpressionList) yyparse (tokenizer, debug_obj);
		}
		
		BinaryExpression Binary (Operator op, object left, object right)
		{
			return new BinaryExpression () { Operator = op, Left = (Expression) left, Right = (Expression) right, Location = (ILocation) left };
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

  protected const int yyFinal = 1;
 // Put this array into a separate class so it is only initialized if debugging is actually used
 // Use MarshalByRefObject to disable inlining
 class YYRules : MarshalByRefObject {
  public static readonly string [] yyRule = {
    "$accept : ExpressionList",
    "ExpressionList :",
    "ExpressionList : ExpressionList Expression",
    "Expression : LogicalExpression",
    "LogicalExpression : ComparisonExpression",
    "LogicalExpression : LogicalExpression AND LogicalExpression",
    "LogicalExpression : LogicalExpression OR LogicalExpression",
    "ComparisonExpression : UnaryExpression",
    "ComparisonExpression : UnaryExpression EQ UnaryExpression",
    "ComparisonExpression : UnaryExpression NE UnaryExpression",
    "ComparisonExpression : UnaryExpression GT UnaryExpression",
    "ComparisonExpression : UnaryExpression GE UnaryExpression",
    "ComparisonExpression : UnaryExpression LT UnaryExpression",
    "ComparisonExpression : UnaryExpression LE UnaryExpression",
    "UnaryExpression : PrimaryExpression",
    "UnaryExpression : NOT UnaryExpression",
    "PrimaryExpression : BooleanLiteral",
    "PrimaryExpression : StringLiteral",
    "PrimaryExpression : UnaryExpression",
    "PrimaryExpression : PropertyAccessExpression",
    "PrimaryExpression : ItemAccessExpression",
    "PrimaryExpression : MetadataAccessExpression",
    "PrimaryExpression : RawStringLiteralOrFunction",
    "PrimaryExpression : ParenthesizedExpression",
    "BooleanLiteral : TRUE_LITERAL",
    "BooleanLiteral : FALSE_LITERAL",
    "PropertyAccessExpression : PROP_OPEN PropertyAccess PAREN_CLOSE",
    "PropertyAccess : NAME",
    "PropertyAccess : Expression DOT NAME",
    "PropertyAccess : BRACE_OPEN QualifiedNameExpression BRACE_CLOSE COLON2 NAME",
    "PropertyAccess : BRACE_OPEN QualifiedNameExpression BRACE_CLOSE COLON2 NAME PAREN_OPEN FunctionCallArguments PAREN_CLOSE",
    "QualifiedNameExpression : QualifiedName",
    "QualifiedName : NAME",
    "QualifiedName : QualifiedName DOT NAME",
    "ItemAccessExpression : ITEM_OPEN ItemApplication PAREN_CLOSE",
    "ItemApplication : NAME",
    "ItemApplication : NAME ARROW ExpressionList",
    "MetadataAccessExpression : METADATA_OPEN MetadataAccess PAREN_CLOSE",
    "MetadataAccess : NAME",
    "MetadataAccess : NAME DOT NAME",
    "StringLiteral : STRING_LITERAL",
    "RawStringLiteralOrFunction : NAME",
    "RawStringLiteralOrFunction : NAME PAREN_OPEN PAREN_CLOSE",
    "RawStringLiteralOrFunction : NAME PAREN_OPEN FunctionCallArguments PAREN_CLOSE",
    "FunctionCallArguments :",
    "FunctionCallArguments : Expression",
    "FunctionCallArguments : FunctionCallArguments COMMA Expression",
    "ParenthesizedExpression : PAREN_OPEN Expression PAREN_CLOSE",
  };
 public static string getRule (int index) {
    return yyRule [index];
 }
}
  protected static readonly string [] yyNames = {    
    "end-of-file",null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,null,null,null,null,null,null,null,
    null,null,null,null,null,null,null,"TRUE_LITERAL","FALSE_LITERAL",
    "STRING_LITERAL","EQ","NE","GT","GE","LT","LE","AND","OR","NOT","DOT",
    "COMMA","PROP_OPEN","ITEM_OPEN","METADATA_OPEN","PAREN_OPEN",
    "PAREN_CLOSE","BRACE_OPEN","BRACE_CLOSE","COLON2","ARROW","NAME",
    "ERROR",
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
#line 124 "ExpressionParser.jay"
  { yyVal = new ExpressionList (); }
  break;
case 2:
#line 126 "ExpressionParser.jay"
  { yyVal = ((ExpressionList) yyVals[-1+yyTop]).Add ((Expression) yyVals[0+yyTop]); }
  break;
case 5:
#line 136 "ExpressionParser.jay"
  { yyVal = Binary (Operator.And, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 6:
#line 138 "ExpressionParser.jay"
  { yyVal = Binary (Operator.Or, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 8:
#line 144 "ExpressionParser.jay"
  { yyVal = Binary (Operator.EQ, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 9:
#line 146 "ExpressionParser.jay"
  { yyVal = Binary (Operator.NE, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 10:
#line 148 "ExpressionParser.jay"
  { yyVal = Binary (Operator.GT, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 11:
#line 150 "ExpressionParser.jay"
  { yyVal = Binary (Operator.GE, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 12:
#line 152 "ExpressionParser.jay"
  { yyVal = Binary (Operator.LT, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 13:
#line 154 "ExpressionParser.jay"
  { yyVal = Binary (Operator.LE, yyVals[-2+yyTop], yyVals[0+yyTop]); }
  break;
case 15:
#line 160 "ExpressionParser.jay"
  { yyVal = new NotExpression () { Negated = (Expression) yyVals[0+yyTop], Location = (ILocation) yyVals[-1+yyTop] }; }
  break;
case 24:
#line 176 "ExpressionParser.jay"
  { yyVal = new BooleanLiteral () { Value = true, Location = (ILocation) yyVals[0+yyTop] }; }
  break;
case 25:
#line 178 "ExpressionParser.jay"
  { yyVal = new BooleanLiteral () { Value = false, Location = (ILocation) yyVals[0+yyTop] }; }
  break;
case 26:
#line 183 "ExpressionParser.jay"
  { yyVal = new PropertyAccessExpression () { Access = (PropertyAccess) yyVals[-1+yyTop], Location = (ILocation) yyVals[-2+yyTop] }; }
  break;
case 27:
#line 188 "ExpressionParser.jay"
  { yyVal = new PropertyAccess () { Name = (NameToken) yyVals[0+yyTop], TargetType = PropertyTargetType.Object, Location = (NameToken) yyVals[0+yyTop] }; }
  break;
case 28:
#line 190 "ExpressionParser.jay"
  { yyVal = new PropertyAccess () { Name = (NameToken) yyVals[0+yyTop], Target = (Expression) yyVals[-2+yyTop], TargetType = PropertyTargetType.Object, Location = (ILocation) yyVals[-2+yyTop] }; }
  break;
case 29:
#line 192 "ExpressionParser.jay"
  { yyVal = new PropertyAccess () { Name = (NameToken) yyVals[0+yyTop], Target = (Expression) yyVals[-3+yyTop], TargetType = PropertyTargetType.Type, Location = (ILocation) yyVals[-4+yyTop] }; }
  break;
case 30:
#line 194 "ExpressionParser.jay"
  { yyVal = new PropertyAccess () { Name = (NameToken) yyVals[-3+yyTop], Target = (Expression) yyVals[-6+yyTop], TargetType = PropertyTargetType.Type, Arguments = (ExpressionList) yyVals[-1+yyTop], Location = (ILocation) yyVals[-7+yyTop] }; }
  break;
case 31:
#line 199 "ExpressionParser.jay"
  { yyVal = new StringLiteral () { Value = (NameToken) yyVals[0+yyTop], Location = (ILocation) yyVals[0+yyTop] }; }
  break;
case 33:
#line 205 "ExpressionParser.jay"
  { yyVal = new NameToken () { Name = ((NameToken) yyVals[-2+yyTop]).Name + "." + ((NameToken) yyVals[0+yyTop]).Name, Column = ((ILocation) yyVals[-2+yyTop]).Column }; }
  break;
case 34:
#line 210 "ExpressionParser.jay"
  { yyVal = new ItemAccessExpression () { Application = (ItemApplication) yyVals[-1+yyTop], Location = (ILocation) yyVals[-2+yyTop] }; }
  break;
case 35:
#line 216 "ExpressionParser.jay"
  { yyVal = new ItemApplication () { Name = (NameToken) yyVals[0+yyTop], Location = (ILocation) yyVals[0+yyTop] }; }
  break;
case 36:
#line 218 "ExpressionParser.jay"
  { yyVal = new ItemApplication () { Name = (NameToken) yyVals[-2+yyTop], Expressions = (ExpressionList) yyVals[0+yyTop], Location = (ILocation) yyVals[-2+yyTop] }; }
  break;
case 37:
#line 223 "ExpressionParser.jay"
  { yyVal = new MetadataAccessExpression () { Access = (MetadataAccess) yyVals[-1+yyTop], Location = (ILocation) yyVals[-2+yyTop] }; }
  break;
case 38:
#line 229 "ExpressionParser.jay"
  { yyVal = new MetadataAccess () { Metadata = (NameToken) yyVals[0+yyTop], Location = (ILocation) yyVals[0+yyTop] }; }
  break;
case 39:
#line 231 "ExpressionParser.jay"
  { yyVal = new MetadataAccess () { ItemType = (NameToken) yyVals[-2+yyTop], Metadata = (NameToken) yyVals[0+yyTop], Location = (ILocation) yyVals[-2+yyTop] }; }
  break;
case 40:
#line 236 "ExpressionParser.jay"
  { yyVal = new StringLiteral () { Value = (NameToken) yyVals[0+yyTop], Location = (ILocation) yyVals[0+yyTop] }; }
  break;
case 41:
#line 241 "ExpressionParser.jay"
  { yyVal = new RawStringLiteral () { Value = (NameToken) yyVals[0+yyTop], Location = (ILocation) yyVals[0+yyTop] }; }
  break;
case 42:
#line 243 "ExpressionParser.jay"
  { yyVal = new FunctionCallExpression () { Name = (NameToken) yyVals[-2+yyTop], Arguments = new ExpressionList (), Location = (ILocation) yyVals[-2+yyTop] }; }
  break;
case 43:
#line 245 "ExpressionParser.jay"
  { yyVal = new FunctionCallExpression () { Name = (NameToken) yyVals[-3+yyTop], Arguments = (ExpressionList) yyVals[-1+yyTop], Location = (ILocation) yyVals[-3+yyTop] }; }
  break;
case 44:
#line 250 "ExpressionParser.jay"
  { yyVal = new ExpressionList (); }
  break;
case 45:
#line 252 "ExpressionParser.jay"
  { yyVal = new ExpressionList ().Add ((Expression) yyVals[0+yyTop]); }
  break;
case 46:
#line 254 "ExpressionParser.jay"
  { yyVal = ((ExpressionList) yyVals[-2+yyTop]).Add ((Expression) yyVals[0+yyTop]); }
  break;
case 47:
#line 259 "ExpressionParser.jay"
  { yyVal = (Expression) yyVals[-1+yyTop]; }
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
#line default
   static readonly short [] yyLhs  = {              -1,
    0,    0,    1,    2,    2,    2,    3,    3,    3,    3,
    3,    3,    3,    4,    4,    5,    5,    5,    5,    5,
    5,    5,    5,    6,    6,    8,   13,   13,   13,   13,
   14,   16,   16,    9,   17,   17,   10,   18,   18,    7,
   11,   11,   11,   15,   15,   15,   12,
  };
   static readonly short [] yyLen = {           2,
    0,    2,    1,    1,    3,    3,    1,    3,    3,    3,
    3,    3,    3,    1,    2,    1,    1,    1,    1,    1,
    1,    1,    1,    1,    1,    3,    1,    3,    5,    8,
    1,    1,    3,    3,    1,    3,    3,    1,    3,    1,
    1,    3,    4,    0,    1,    3,    3,
  };
   static readonly short [] yyDefRed = {            1,
    0,   24,   25,   40,    0,    0,    0,    0,    0,    0,
    2,    0,    4,    0,   14,   16,   17,   19,   20,   21,
   22,   23,   15,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,   32,    0,    0,    0,   26,    1,   34,    0,   37,
   47,   42,   45,    0,    0,    0,    8,    9,   10,   11,
   12,   13,    0,    0,   28,    0,   39,    0,   43,    0,
   33,   46,    0,    0,    0,   30,
  };
  protected static readonly short [] yyDgoto  = {             1,
   11,   12,   13,   14,   15,   16,   17,   18,   19,   20,
   21,   22,   27,   43,   54,   44,   29,   31,
  };
  protected static readonly short [] yySindex = {            0,
 -188,    0,    0,    0, -188, -250, -276, -274, -188, -257,
    0, -238,    0, -249,    0,    0,    0,    0,    0,    0,
    0,    0,    0, -261, -257, -244, -243, -248, -231, -222,
 -227, -223, -208, -188, -188, -188, -188, -188, -188, -188,
 -188,    0, -224, -215, -225,    0,    0,    0, -221,    0,
    0,    0,    0, -265, -238, -238,    0,    0,    0,    0,
    0,    0, -217, -207,    0, -188,    0, -188,    0, -206,
    0,    0, -218, -188, -230,    0,
  };
  protected static readonly short [] yyRindex = {            0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    1,
    0,   39,    0,   20,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0, -167,    0,    0, -200,    0, -199,
    0,    0, -213,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0, -198,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,   58,   77,    0,    0,    0,    0,
    0,    0,    0,    0,    0, -197,    0,    0,    0,    0,
    0,    0, -194, -229,    0,    0,
  };
  protected static readonly short [] yyGindex = {           35,
   -6,    8,    0,   -3,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,   13,    0,    0,    0,
  };
  protected static readonly short [] yyTable = {            26,
   41,   23,   32,   28,   68,   30,    2,    3,    4,   69,
   36,   37,   38,   39,   40,   41,   33,    5,   42,    7,
    6,    7,    8,    9,   45,   24,   53,   34,   35,   25,
   47,   46,   57,   58,   59,   60,   61,   62,    3,   68,
   44,   55,   56,   48,   76,   44,   49,   50,    2,    3,
    4,   51,   63,   64,   65,   74,   44,    5,   67,    5,
   70,   72,    6,    7,    8,    9,   52,   53,    2,    3,
    4,   10,   71,   73,   35,   38,    6,   36,   31,    5,
   29,   66,    6,    7,    8,    9,   75,    0,    0,    0,
    0,   10,   41,   41,   41,   41,   41,   41,   41,   41,
    0,   41,    0,    0,    0,    0,    0,   27,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,
    0,    0,    0,    0,    0,    0,    0,   41,   41,   41,
   41,   41,   41,   41,   41,   41,   41,   41,   41,   41,
   41,   41,   41,   41,    0,   41,    7,    7,    7,    0,
   41,    0,    0,    0,    0,    7,    7,    7,    7,    7,
    7,    7,    7,    7,    7,    3,    3,    3,    0,    7,
    0,    0,    0,    0,    0,    0,    3,    3,    3,    3,
    3,    3,    3,    3,    5,    5,    5,    0,    3,    0,
    0,    0,    0,    0,    0,    5,    5,    5,    5,    5,
    5,    5,    5,    6,    6,    6,    0,    5,    0,    0,
    0,    0,    0,    0,    6,    6,    6,    6,    6,    6,
    6,    6,    0,    0,    0,    0,    6,
  };
  protected static readonly short [] yyCheck = {             6,
    0,    5,    9,  280,  270,  280,  257,  258,  259,  275,
  260,  261,  262,  263,  264,  265,  274,  268,  280,    0,
  271,  272,  273,  274,  269,  276,   33,  266,  267,  280,
  279,  275,   36,   37,   38,   39,   40,   41,    0,  270,
  270,   34,   35,  275,  275,  275,  269,  275,  257,  258,
  259,  275,  277,  269,  280,  274,  270,    0,  280,  268,
  278,   68,  271,  272,  273,  274,  275,   74,  257,  258,
  259,  280,  280,  280,  275,  275,    0,  275,  277,  268,
  275,   47,  271,  272,  273,  274,   74,   -1,   -1,   -1,
   -1,  280,  260,  261,  262,  263,  264,  265,  266,  267,
   -1,  269,   -1,   -1,   -1,   -1,   -1,  275,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,   -1,
   -1,   -1,   -1,   -1,   -1,   -1,   -1,  257,  258,  259,
  260,  261,  262,  263,  264,  265,  266,  267,  268,  269,
  270,  271,  272,  273,   -1,  275,  257,  258,  259,   -1,
  280,   -1,   -1,   -1,   -1,  266,  267,  268,  269,  270,
  271,  272,  273,  274,  275,  257,  258,  259,   -1,  280,
   -1,   -1,   -1,   -1,   -1,   -1,  268,  269,  270,  271,
  272,  273,  274,  275,  257,  258,  259,   -1,  280,   -1,
   -1,   -1,   -1,   -1,   -1,  268,  269,  270,  271,  272,
  273,  274,  275,  257,  258,  259,   -1,  280,   -1,   -1,
   -1,   -1,   -1,   -1,  268,  269,  270,  271,  272,  273,
  274,  275,   -1,   -1,   -1,   -1,  280,
  };

#line 263 "ExpressionParser.jay"

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
  public const int TRUE_LITERAL = 257;
  public const int FALSE_LITERAL = 258;
  public const int STRING_LITERAL = 259;
  public const int EQ = 260;
  public const int NE = 261;
  public const int GT = 262;
  public const int GE = 263;
  public const int LT = 264;
  public const int LE = 265;
  public const int AND = 266;
  public const int OR = 267;
  public const int NOT = 268;
  public const int DOT = 269;
  public const int COMMA = 270;
  public const int PROP_OPEN = 271;
  public const int ITEM_OPEN = 272;
  public const int METADATA_OPEN = 273;
  public const int PAREN_OPEN = 274;
  public const int PAREN_CLOSE = 275;
  public const int BRACE_OPEN = 276;
  public const int BRACE_CLOSE = 277;
  public const int COLON2 = 278;
  public const int ARROW = 279;
  public const int NAME = 280;
  public const int ERROR = 281;
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
