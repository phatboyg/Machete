namespace Machete
{
    using TextParsers;


    public static class SplitExtensions
    {
        public static ITextParser Split(this ITextParser parser, ITextParser separator)
        {
            return new SplitParser(parser, separator);
        }

        public static ITextParser Split(this ITextParser parser, ITextParser separator, ITextParser terminator)
        {
            return new SplitWithTerminatorParser(parser, separator, terminator);
        }
    }
}