namespace Machete.X12.Parsers
{
    using System.Threading.Tasks;
    using Cursors;
    using Machete.Parsers;
    using Slices;
    using Texts;


    /// <summary>
    /// Parses X12 entities from text, given a single X12 message
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public class X12EntityParser<TSchema> :
        SchemaEntityParser<TSchema>
        where TSchema : X12Entity
    {
        readonly ITextParser _messageParser = new X12MessageTextParser();

        public X12EntityParser(ISchema<TSchema> schema)
            : base(schema)
        {
        }

        public override ParseResult<TSchema> Parse(ParseText text, TextSpan span)
        {
            if (span.Length == 0)
                return new EmptyParseResult<TSchema>(Schema, this, text, span);

            int i = span.Start;
            for (; i < span.End; i++)
                if (!char.IsWhiteSpace(text[i]))
                    break;

            if (i + 106 > span.End)
                throw new MacheteParserException("The ISA segment must contain at least 106 characters");

            if (i + 127 > span.End)
                throw new MacheteParserException("The GS segment could not be present due to length");

            if (text[i] != 'I' || text[i + 1] != 'S' || text[i + 2] != 'A')
                throw new MacheteParserException("Malformed X12 message. The message body must start with an ISA segment.");

            var settings = GetParserSettings(text, TextSpan.FromBounds(i, span.End));

            var streamText = new StreamText(text, null);

            var textCursor = new StreamTextCursor(streamText, TextSpan.FromBounds(i, span.End), TextSpan.FromBounds(span.End, span.End), _messageParser);

            return new X12ParseResult<TSchema>(Schema, this, settings, textCursor);
        }

        public override async Task<ParseResult<TSchema>> ParseStream(StreamText text, TextSpan span)
        {
            var result = await StreamTextCursor.ParseText(text, span, _messageParser);
            if (!result.HasCurrent)
                return new EmptyParseResult<TSchema>(Schema, this, text, span);

            var settings = GetParserSettings(result.InputText, result.CurrentSpan);

            return new X12ParseResult<TSchema>(Schema, this, settings, result);
        }

        static X12ParserSettings GetParserSettings(ParseText text, TextSpan span)
        {
            int elementDelimiterOffset = span.Start + 3;
            int repetitionDelimiterOffset = span.Start + 82;
            int subElementDelimiterOffset = span.Start + 104;
            int segmentDelimiterOffset = span.Start + 105;

            return new ParsedX12Settings
            {
                ElementSeparator = TryGetElementDelimiter(text, elementDelimiterOffset, out char elementDelimiter)
                    ? elementDelimiter
                    : throw new MacheteParserException($"Element delimiter at position {elementDelimiterOffset} is missing or invalid."),
                RepetitionSeparator = TryGetRepetitionDelimiter(text, repetitionDelimiterOffset, out char repetitionDelimiter)
                    ? repetitionDelimiter
                    : throw new MacheteParserException($"Repition delimiter at position {repetitionDelimiterOffset} is missing or invalid."),
                SubElementSeparator = TryGetElementDelimiter(text, subElementDelimiterOffset, out char subElementDelimiter)
                    ? subElementDelimiter
                    : throw new MacheteParserException($"Sub-element delimiter at position {subElementDelimiterOffset} is missing or invalid."),
                SegmentSeparator = TryGetEndOfLineDelimiter(text, segmentDelimiterOffset, out char segmentDelimiter)
                    ? segmentDelimiter
                    : throw new MacheteParserException($"Segment delimiter at position {segmentDelimiterOffset} is missing or invalid."),
            };
        }

        static bool TryGetRepetitionDelimiter(ParseText text, int offset, out char separator)
        {
            if (offset >= text.Length || offset < 0 || char.IsWhiteSpace(text[offset]) || char.IsDigit(text[offset]))
            {
                separator = default;
                return false;
            }

            separator = text[offset];
            return true;
        }

        static bool TryGetElementDelimiter(ParseText text, int offset, out char separator)
        {
            if (offset >= text.Length || offset < 0 || char.IsWhiteSpace(text[offset]) || char.IsLetterOrDigit(text[offset]))
            {
                separator = default;
                return false;
            }

            separator = text[offset];
            return true;
        }

        static bool TryGetEndOfLineDelimiter(ParseText text, int offset, out char separator)
        {
            if (offset >= text.Length || offset < 0 || char.IsLetterOrDigit(text[offset]))
            {
                separator = default;
                return false;
            }

            separator = text[offset];
            return true;
        }
    }
}