namespace Machete.TextParsers
{
    using System;


    public class CharTextParser :
        TextParser
    {
        readonly Func<char, bool> _condition;
        readonly TextParser _parser;

        public CharTextParser(TextParser parser, Func<char, bool> condition)
        {
            _parser = parser;
            _condition = condition;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return _parser.Parse(text, span)
                .Where(x => x.Length > 0 && _condition(text[x.Start]))
                .Select((next, x) => new Success<TextSpan, TextSpan>(x.First, x.Skip(1) + next));
        }
    }
}