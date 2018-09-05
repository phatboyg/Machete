namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Selects a matching result from the parser and applies a projection to the result type
    /// </summary>
    public class SelectTextParser :
        ITextParser
    {
        readonly ITextParser _parser;
        readonly Func<TextSpan, TextSpan> _projector;

        public SelectTextParser(ITextParser parser, Func<TextSpan, TextSpan> projector)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _projector = projector ?? throw new ArgumentNullException(nameof(projector));
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return _parser.Parse(text, span).Select(x => _projector(x));
        }
    }
}