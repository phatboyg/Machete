namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Parses the text span based on a specified condition
    /// </summary>
    public class CharTextParser :
        ITextParser
    {
        readonly Func<char, bool> _condition;
        readonly ITextParser _parser;

        public CharTextParser(ITextParser parser, Func<char, bool> condition)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _condition = condition ?? throw new ArgumentNullException(nameof(condition));
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return _parser.Parse(text, span)
                .Where(x => x.Length > 0 && _condition(text[x.Start]))
                .Select((next, x) => new Success<TextSpan, TextSpan>(x.First, x.Skip(1) + next));
        }
    }
}