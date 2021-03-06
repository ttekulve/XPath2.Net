namespace Wmhelp.XPath2.Properties
{
    public static class Resources
    {
        public static string BadCharRef = "Bad character ref constant &#{0}{1};";
        public static string BinaryOperatorNotDefined = "Operator {0}  is not defined for arguments of type {1} and {2}";
        public static string ContextItemNotDefined = "The context item cannot be defined";
        public static string ExpectedAtomicValue = "Expected atomic value";
        public static string ExpectedBlockStart = "Expected {{ after {0} {1}";
        public static string ExpectedModuleDecl = "Expected module declaration";
        public static string ExpectedNCName = "Expected NCName after *:";
        public static string ExpectedQNamePrefix = "The {0} qualified name '{1}' must have a prefix";
        public static string ExpectedVariablePrefix = "Expected prefix $ after {0}";
        public static string ExpectingCharAfterQName = "Expecting {0} after QName";
        public static string ExternalVariableNotSet = "External variable {0} not set before run command";
        public static string FileNotFound = "File {0} is not found in current path";
        public static string FOAR0001 = "Division by zero";
        public static string FOAR0002 = "Numeric operation overflow/underflow";
        public static string FOCA0002 = "QName {0} has null namespace but non-empty prefix";
        public static string FOCA0005 = "NaN supplied as float/double value";
        public static string FOCH0001 = "Invalid XML character [x{0}]";
        public static string FODC0001 = "No context document";
        public static string FODC0004 = "Invalid argument '{0}' to fn:collection";
        public static string FODT0001 = "Overflow/underflow in date/time operation";
        public static string FODT0002 = "Overflow/underflow in duration operation";
        public static string FODT0003 = "Invalid timezone value {0}";
        public static string FOER0000 = "Unidentified error";
        public static string FONS0005 = "Base-uri not defined in the static context";
        public static string FORG0001 = "The value '\"{0}\"' is an invalid argument for constructor/cast {1}";
        public static string FORG0003 = "Function 'zero-or-one' was called with a sequence containing more than one item";
        public static string FORG0004 = "Function 'one-or-more' was called with a sequence containing no items";
        public static string FORG0005 = "Function 'exactly-one' was called with a sequence containing zero or more than one item";
        public static string FORG0006 = "Function '{0}' was called with invalid argument type {1}";
        public static string FORG0008 = "Both arguments to fn:dateTime have a specified timezone";
        public static string FORG0009 = "Error in resolving a relative URI against a base URI in fn:resolve-uri";
        public static string FORX0003 = "Regular expression {0} matches zero-length string";
        public static string FORX0004 = "Invalid replacement string {0}";
        public static string FOTY0012 = "Argument node {0} does not have a typed value";
        public static string InvalidAttributeSequence = "The content sequence of a document node may not contain an attribute node";
        public static string InvalidFormat = "Input string {0} has invalid format for type {1}";
        public static string InvalidPITarget = "The target xml is invalid for processing instruction";
        public static string InvalidRegularExpr = "The regular expression '{0}' is invalid";
        public static string InvalidRegularExpressionFlags = "Invalid regular expression flags {0}";
        public static string MoreThanOneItem = "More than one item in sequence in atomic expression";
        public static string Sch_EnumFinished = "Enumeration finished";
        public static string Sch_EnumNotStarted = "Enumeration not started";
        public static string UnaryOperatorNotDefined = "Operator {0}  is not defined for argument of type {1}";
        public static string UnexpectedChar = "Unexpected char {0}";
        public static string UnexpectedEOF = "Unexpected end of file";
        public static string UnknownExternalVariable = "Variable  {0} is not defined as external";
        public static string UnsupportedNormalizationForm = "Unsupported normalization form {0}";
        public static string XPDY0002 = "The context item cannot be defined";
        public static string XPST0003 = "Syntax error. {0}";
        public static string XPST0004 = "Expected type {0}";
        public static string XPST0008 = "Qname {0} is not defined";
        public static string XPST0017 = "The function '{0}'/{1} was not found in namespace '{2}'";
        public static string XPST0051 = "The type name '{0}' has been used as an atomic type in a sequence type, but is not defined in the in-scope schema types as an atomic type";
        public static string XPST0080 = "Cannot cast to {0}. The target type of a cast or castable expression must be an atomic type that is in the in-scope schema types and is not xs:NOTATION or xs:anyAtomicType, optionally followed by the occurrence indicator \"?\"";
        public static string XPST0081 = "The prefix '{0}' cannot be expanded into a namespace URI by using the statically known namespaces";
        public static string XPTY0004 = "Dynamic type {0} of a value does not match a required type {1}";
        public static string XPTY0004_CAST = "Only string literals can be cast to type {0}";
        public static string XPTY0018 = "The result of the last step in a path expression contains both nodes and atomic values {0}";
        public static string XPTY0019 = "The result of a step in path expression must not be an atomic value {0}";
        public static string XQDY0025 = "Element constructor \"{0}\" contains a duplicate attribute node \"{1}\"";
        public static string XQDY0026 = "The result of the content expression of a computed processing instruction constructor contains the string \"?>\"";
        public static string XQDY0044 = "The node name of a computed attribute may not be 'xmlns' because attribute constructors cannot create namespaces";
        public static string XQDY0064 = "The computed processing instruction target cannot be equal to \"XML\" in any combination of upper or lower case";
        public static string XQDY0072 = "The result of the content expression of a computed comment constructor contains two adjacent hyphens or ends with a hyphen";
        public static string XQST0022 = "The namespace bound to prefix '{0}' must be a URI literal.  Enclosed expressions are not permitted.";
        public static string XQST0031 = "XQuery version '{0}' is not supported by this implementation";
        public static string XQST0032 = "The module prolog contains more than one base URI declaration";
        public static string XQST0033 = "The module contains multiple bindings for the same namespace prefix {0}.";
        public static string XQST0034 = "The function '{0}' in namespace '{1}' has already been declared with the same number of arguments";
        public static string XQST0038 = "The module prolog contains more than one default collation declaration, or the value specified by a default collation declaration is not present in statically known collations";
        public static string XQST0039 = "Function declaration has more than one parameter with name '{0}'";
        public static string XQST0040 = "The attribute '{0}' is a duplicate.  Attributes specified by a direct  element constructor must have distinct expanded qualified names.";
        public static string XQST0045 = "The function '{0}' cannot be declared in the namespace '{1}'";
        public static string XQST0047 = "Multiple module imports in the same Prolog specify the same target namespace {0}";
        public static string XQST0049 = "The variable {0} is already defined in module";
        public static string XQST0054 = "A {0} variable depends on itself";
        public static string XQST0055 = "The prolog must not contain more than one copy-namespaces declaration";
        public static string XQST0058 = "Multiple schema imports specify the same target namespace {0}";
        public static string XQST0059 = "Implementation is unable to process a schema or module import by finding a schema or module with the specified target namespace {0}.";
        public static string XQST0065 = "The module prolog contains more than one ordering mode declaration";
        public static string XQST0066 = "The module contains more than one default element/type namespace declaration, or more than one default function namespace declaration.";
        public static string XQST0067 = "The module prolog contains more than one construction declaration";
        public static string XQST0068 = "The module prolog contains more than one boundary-space declaration";
        public static string XQST0069 = "The module  prolog contains more than one empty order declaration";
        public static string XQST0070 = "A namespace URI {0} is bound to the predefined prefix xmlns, or if a namespace URI other than http://www.w3.org/XML/1998/namespace is bound to the prefix xml, or if the prefix xml is bound to a namespace URI other than http://www.w3.org/XML/1998/namespace.";
        public static string XQST0073 = "The graph of module imports contains a cycle in file {0}";
        public static string XQST0076 = "'{0}' does not identify a collation that is present in statically known collations";
        public static string XQST0087 = "String literal '{0}' is not a valid encoding name";
        public static string XQST0088 = "The literal that specifies the target namespace in a module import or a module declaration is of zero length";
        public static string XQST0089 = "The bound variable '{0}' in a FLWOR expression must be distinct from the positional variable";
        public static string XQTY0024 = "Content sequence in an element constructor contains an attribute node \"{0}\" following a node that is not an attribute node";
        public static string XQTY0030 = "The argument of a validate expression does not evaluate to exactly one document or element node";
    }
}