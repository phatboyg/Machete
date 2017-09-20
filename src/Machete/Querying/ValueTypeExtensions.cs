namespace Machete
{
    using System;
    using Parsers;
    using TextParsers;


    public static class ValueTypeExtensions
    {
        public static TextParser<Int32> Int32(this TextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            var integerParser = parser.Char(char.IsDigit).Or(parser.Char('-')).OneOrMore();

            return new ValueTypeParser<Int32>(integerParser, TryGetInt32);
        }

        static bool TryGetInt32(ParseText text, TextSpan span, out Int32 value)
        {
            return int.TryParse(text.ToString(span), out value);
        }
    }
}