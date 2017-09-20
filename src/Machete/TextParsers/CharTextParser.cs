namespace Machete.TextParsers
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
            if (result.HasResult)
            {
                var resultSpan = result.Result;
                if (resultSpan.Length > 0 && _condition(text[resultSpan.Start]))
                    return new Success<TextSpan, TextSpan>(resultSpan.First, resultSpan.Skip(1) + result.Next);
            }

            return new Unmatched<TextSpan, TextSpan>(result.Next);
        }
    }
}