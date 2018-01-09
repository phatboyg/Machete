namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Parses uses the specified parser only if the except parser is unsuccessful
    /// </summary>
    public class ExceptTextParser :
        ITextParser
    {
        readonly ITextParser _except;
        readonly ITextParser _parser;

        public ExceptTextParser(ITextParser parser, ITextParser except)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _except = except ?? throw new ArgumentNullException(nameof(except));
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var parsed = _except.Parse(text, span);
            
            return parsed.HasResult ? new Unmatched<TextSpan, TextSpan>(span) : _parser.Parse(text, span);
        }
    }
}