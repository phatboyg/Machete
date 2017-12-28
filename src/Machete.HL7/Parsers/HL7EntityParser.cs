namespace Machete.HL7.Parsers
{
    using System.Threading.Tasks;
    using Cursors;
    using Machete.Parsers;
    using Slices;
    using Texts;


    public class HL7EntityParser<TSchema> :
        SchemaEntityParser<TSchema>
        where TSchema : HL7Entity
    {
        readonly ITextParser _messageParser = new HL7MessageParser();

        public HL7EntityParser(ISchema<TSchema> schema)
            : base(schema)
        {
        }

        public override ParseResult<TSchema> Parse(ParseText text, TextSpan span)
        {
            var result = _messageParser.Parse(text, span);
            if (!result.HasResult)
                return new EmptyParseResult<TSchema>(Schema, this, text, result.Next);

            if (span.Length == 0)
                return new EmptyParseResult<TSchema>(Schema, this, text, span);

            var settings = ParseSettings(text, result.Result);

            var streamText = new StreamText(text, null);

            var textCursor = new StreamTextCursor(streamText, result.Result, result.Next, _messageParser);

            return new HL7ParseResult<TSchema>(Schema, this, settings, textCursor);
        }

        public override async Task<ParseResult<TSchema>> ParseStream(StreamText text, TextSpan span)
        {
            var result = await StreamTextCursor.ParseText(text, span, _messageParser);
            if (!result.HasCurrent)
                return new EmptyParseResult<TSchema>(Schema, this, text, result.NextSpan);

            var settings = ParseSettings(result.InputText, result.CurrentSpan);

            return new HL7ParseResult<TSchema>(Schema, this, settings, result);
        }

        static HL7ParserSettings ParseSettings(ParseText text, TextSpan span)
        {
            var offset = span.Start;

            HL7ParserSettings settings = new ParsedHL7Settings
            {
                FieldSeparator = text[offset + 3],
                ComponentSeparator = text[offset + 4],
                RepetitionSeparator = text[offset + 5],
                EscapeCharacter = text[offset + 6] != '\\' ? default(char) : text[offset + 6],
                SubComponentSeparator = text[offset + 7]
            };
            return settings;
        }
    }
}