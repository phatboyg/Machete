namespace Machete
{
    using Parsers.TextParsers;


    public static class SplitExtensions
    {
        public static TextParser Split(this TextParser parser, TextParser separator)
        {
            return new SplitParser(parser, separator);
        }

        public static TextParser Split(this TextParser parser, TextParser separator, TextParser terminator)
        {
            return new SplitWithTerminatorParser(parser, separator, terminator);
        }
    }
}