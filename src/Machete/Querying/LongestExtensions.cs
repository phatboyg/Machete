namespace Machete
{
    using System;
    using TextParsers;


    public static class LongestExtensions
    {
        public static TextParser Longest(this TextParser parser, params TextParser[] parsers)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (parsers == null)
                throw new ArgumentNullException(nameof(parsers));
            for (int i = 0; i < parsers.Length; i++)
            {
                if (parsers[i] == null)
                    throw new ArgumentNullException(nameof(parsers), $"Parser at position {i} was null");
            }

            return new LongestTextParser(parser, parsers);
        }
    }
}