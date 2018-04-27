namespace Machete.HL7.Parsers
{
    using System;


    /// <summary>
    /// Parses an HL7 message from the input text, separating in the case of multiple messages in the same body
    /// </summary>
    public class HL7StreamingMessageParser :
        ITextParser
    {
        readonly ITextParser _parser;
        readonly ITextParser _orParser;

        public HL7StreamingMessageParser(ITextParser parser, ITextParser orParser)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _orParser = orParser ?? throw new ArgumentNullException(nameof(orParser));
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var result = _parser.Parse(text, span);
            
            return result.HasResult ? result : _orParser.Parse(text, span);
        }
    }
}