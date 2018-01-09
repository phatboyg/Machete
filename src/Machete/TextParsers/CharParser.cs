namespace Machete.TextParsers
{
    using System;


    public class CharParser :
        ITextParser<char>
    {
        readonly Func<char, bool> _condition;

        public CharParser(Func<char, bool> condition)
        {
            _condition = condition ?? throw new ArgumentNullException(nameof(condition));
        }

        public Result<TextSpan, char> Parse(ParseText text, TextSpan span)
        {
            if (span.Length > 0)
            {
                var value = text[span.Start];

                if (_condition(value))
                    return new Success<TextSpan, char>(value, span.Skip(1));
            }

            return new Unmatched<TextSpan, char>(span);
        }
    }
}