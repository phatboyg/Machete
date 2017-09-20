namespace Machete.TextParsers
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
            if (!result.HasResult)
                return new Unmatched<TextSpan, IReadOnlyList<TextSpan>>(result.Next);

            List<TextSpan> spans = new List<TextSpan>();
            while (result.HasResult)
            {
                if (next == result.Next)
                    break;

                spans.Add(result.Result);

                next = result.Next;

                result = _parser.Parse(text, next);
            }

            return new Success<TextSpan, IReadOnlyList<TextSpan>>(spans, next);
        }
    }
}