namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Selects a matching result from the parser, and applies a projection to the result type
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class SelectTextParser<TResult> :
        TextParser<TResult>
    {
        readonly TextParser _parser;
        readonly Func<ParseText, TResult> _projector;

        public SelectTextParser(TextParser parser, Func<ParseText, TResult> projector)
        {
            _parser = parser;
            _projector = projector;
        }

        public Result<TextSpan, TResult> Parse(ParseText text, TextSpan span)
        {
            var parsed = _parser.Parse(text, span);
            if (parsed.HasResult)
            {
                TResult result = _projector(text.GetSubText(parsed.Result));

                return new Success<TextSpan, TResult>(result, parsed.Next);
            }

            return new Unmatched<TextSpan, TResult>(parsed.Next);
        }
    }


    /// <summary>
    /// Selects a matching result from the parser, and applies a projection to the result type
    /// </summary>
    public class SelectTextParser :
        TextParser
    {
        readonly TextParser _parser;
        readonly Func<TextSpan, TextSpan> _projector;

        public SelectTextParser(TextParser parser, Func<TextSpan, TextSpan> projector)
        {
            _parser = parser;
            _projector = projector;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var parsed = _parser.Parse(text, span);
            if (parsed.HasResult)
            {
                TextSpan result = _projector(parsed.Result);

                return new Success<TextSpan, TextSpan>(result, parsed.Next);
            }

            return new Unmatched<TextSpan, TextSpan>(parsed.Next);
        }
    }
}