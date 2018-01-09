namespace Machete.TextParsers
{
    using System;


    public class ValueTypeParser<T> :
        ITextParser<T>
        where T : struct
    {
        readonly ITextParser _parser;
        readonly ParsedValueTypeConverter<T> _converter;

        public ValueTypeParser(ITextParser parser, ParsedValueTypeConverter<T> converter)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }

        public Result<TextSpan, T> Parse(ParseText text, TextSpan span)
        {
            var parsed = _parser.Parse(text, span);
            if (parsed.HasResult && _converter(text, parsed.Result, out T result))
                return new Success<TextSpan, T>(result, parsed.Next);

            return new Unmatched<TextSpan, T>(parsed.Next);
        }
    }
}