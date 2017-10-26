namespace Machete.HL7.Parsers
{
    using System.Threading.Tasks;
    using Cursors;
    using Machete.Parsers;
    using Slices;
    using Texts;


    public class HL7Parser<TSchema> :
        SchemaParser<TSchema>
        where TSchema : HL7Entity
    {
        readonly TextParser _messageParser = new HL7MessageParser();

        public HL7Parser(ISchema<TSchema> schema)
            : base(schema)
        {
        }

        public override ParseResult<TSchema> Parse(ParseText text, TextSpan span)
        {
            if (span.Length == 0)
                throw new MacheteParserException("The body was empty");

            int i = span.Start;
            for (; i < span.End; i++)
            {
                if (!char.IsWhiteSpace(text[i]))
                    break;
            }

            if (i + 8 > span.End)
                throw new MacheteParserException("The body must contain at least 8 characters");

            if (text[i] != 'M' || text[i + 1] != 'S' || text[i + 2] != 'H')
                throw new MacheteParserException("The body must start with an MSH segment");

            var settings = GetHL7Settings(text, TextSpan.FromBounds(i, span.End));

            var streamText = new StreamText(text, null);

            var textCursor = new StreamTextCursor(streamText, TextSpan.FromBounds(i, span.End), TextSpan.FromBounds(span.End, span.End), _messageParser);

            return new HL7ParseResult<TSchema>(Schema, settings, textCursor);
        }

        public override async Task<ParseResult<TSchema>> ParseAsync(StreamText text, TextSpan span)
        {
            var result = await StreamTextCursor.ParseText(text, span, _messageParser);
            if (!result.HasCurrent)
                return new EmptyParseResult<TSchema>(Schema, text, span);

            var settings = GetHL7Settings(result.InputText, result.CurrentSpan);

            return new HL7ParseResult<TSchema>(Schema, settings, result);
        }

        static HL7ParserSettings GetHL7Settings(ParseText text, TextSpan span)
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