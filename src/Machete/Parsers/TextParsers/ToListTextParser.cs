namespace Machete.Parsers.TextParsers
{
    using System.Collections.Generic;


    public class ToListTextParser :
        TextParser<IReadOnlyList<TextSpan>>
    {
        readonly TextParser _parser;

        public ToListTextParser(TextParser parser)
        {
            _parser = parser;
        }

        public Result<TextSpan, IReadOnlyList<TextSpan>> Parse(ParseText text, TextSpan span)
        {
            var next = span;

            var result = _parser.Parse(text, span);
            if (!result.HasValue)
                return new Unmatched<TextSpan, IReadOnlyList<TextSpan>>(result.Next);

            List<TextSpan> spans = new List<TextSpan>();
            while (result.HasValue)
            {
                if (next == result.Next)
                    break;

                spans.Add(result.Value);

                next = result.Next;

                result = _parser.Parse(text, next);
            }

            return new Success<TextSpan, IReadOnlyList<TextSpan>>(spans, next);
        }
    }
}