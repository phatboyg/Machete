namespace Machete.TextParsers
{
    using System;
    using System.Collections.Generic;


    public class ToListTextParser :
        ITextParser<IReadOnlyList<TextSpan>>
    {
        readonly ITextParser _parser;

        public ToListTextParser(ITextParser parser)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
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