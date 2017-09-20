namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Selects a matching result from the parser, and applies a projection to the result type
    /// </summary>
    public class SelectTextParser :
        TextParser
    {
        readonly TextParser _parser;
        readonly Func<TextSpan, TextSpan> _projector;

        public SelectTextParser(TextParser parser, Func<TextSpan, TextSpan> projector)
        {
            _parser = parser;
            _projector = projector;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return _parser.Parse(text, span).Select(x => _projector(x));
        }
    }
}