namespace Machete.Parsers.TextParsers
{
    using System;


    public class CharTextParser :
        TextParser
    {
        readonly TextParser _parser;
        readonly Func<char, bool> _condition;

        public CharTextParser(TextParser parser, Func<char, bool> condition)
        {
            _parser = parser;
            _condition = condition;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var result = _parser.Parse(text, span);
            if (result.HasValue)
            {
                var resultSpan = result.Value;
                if (resultSpan.Length > 0 && _condition(text[resultSpan.Start]))
                    return new Success<TextSpan, TextSpan>(new TextSpan(resultSpan.Start, 1), TextSpan.FromBounds(resultSpan.Start + 1, resultSpan.End));
            }
            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}