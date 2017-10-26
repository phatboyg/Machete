namespace Machete.X12.Parsers
{
    using System.Threading.Tasks;
    using Cursors;
    using Machete.Parsers;
    using Slices;
    using Texts;


    public class X12Parser<TSchema> :
        SchemaParser<TSchema>
        where TSchema : X12Entity
    {
        readonly TextParser _messageParser = new X12MessageParser();

        public X12Parser(ISchema<TSchema> schema)
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

            if (i + 106 > span.End)
                throw new MacheteParserException("The ISA segment must contain at least 106 characters");

            if (i + 127 > span.End)
                throw new MacheteParserException("The GS segment could not be present due to length");

            if (text[i] != 'I' || text[i + 1] != 'S' || text[i + 2] != 'A')
                throw new MacheteParserException("The body must start with an ISA segment");

            var settings = GetX12Settings(text, TextSpan.FromBounds(i, span.End));

            var streamText = new StreamText(text, null);

            var textCursor = new StreamTextCursor(streamText, TextSpan.FromBounds(i, span.End), TextSpan.FromBounds(span.End, span.End), _messageParser);

            return new X12ParseResult<TSchema>(Schema, settings, textCursor);
        }

        public override async Task<ParseResult<TSchema>> ParseAsync(StreamText text, TextSpan span)
        {
            var result = await StreamTextCursor.ParseText(text, span, _messageParser);
            if (!result.HasCurrent)
                return new EmptyParseResult<TSchema>(Schema, text, span);

            var settings = GetX12Settings(result.InputText, result.CurrentSpan);

            return new X12ParseResult<TSchema>(Schema, settings, result);
        }

        static X12ParserSettings GetX12Settings(ParseText text, TextSpan span)
        {
            var offset = span.Start;

            return new ParsedX12Settings
            {
                ElementSeparator = text[offset + 3],
                RepetitionSeparator = text[offset + 82],
                SubElementSeparator = text[offset + 104],
                SegmentSeparator = text[offset + 105],
            };
        }
    }
}