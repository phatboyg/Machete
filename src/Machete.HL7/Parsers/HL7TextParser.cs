namespace Machete.HL7.Parsers
{
    using System.Text;


    public class HL7TextParser :
        TextParser
    {
        readonly HL7Settings _settings;

        public HL7TextParser(HL7Settings settings)
        {
            _settings = settings;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.IsEmpty)
                return new Unmatched<TextSpan, TextSpan>(span);

            if (span.Length == 2 && text[span.Start] == '"' && text[span.Start + 1] == '"')
                return new Success<TextSpan, TextSpan>(new TextSpan(span.Start, 2), TextSpan.FromBounds(span.Start + 2, span.End));

            var index = text.IndexOf(_settings.EscapeCharacter, span);
            if (index < 0)
                return new Success<TextSpan, TextSpan>(span, new TextSpan(span.End, 0));

            var builder = new StringBuilder(span.Length);

            int offset = span.Start;
            while ((index >= 0) && offset < span.End)
            {
                text.AppendTo(builder, TextSpan.FromBounds(offset, index - offset));

                offset = ParseEscapeSequence(builder, text, TextSpan.FromBounds(index, span.End));

                index = text.IndexOf(_settings.EscapeCharacter, TextSpan.FromBounds(offset, span.End));
            }

            if (offset < span.End)
            {
                text.AppendTo(builder, TextSpan.FromBounds(offset, span.End));
                offset = span.End;
            }

            return new Success<TextSpan, TextSpan>(TextSpan.FromBounds(span.Start, offset), TextSpan.FromBounds(offset, span.End));
        }

        int ParseEscapeSequence(StringBuilder builder, ParseText body, TextSpan span)
        {
            if (span.Length < 3)
            {
                body.AppendTo(builder, span);

                return span.End;
            }

            char key = body[span.Start + 1];
            char closing = body[span.Start + 2];
            if (closing == _settings.EscapeCharacter)
            {
                switch (key)
                {
                    case 'F':
                        builder.Append(_settings.FieldSeparator);
                        break;
                    case 'S':
                        builder.Append(_settings.ComponentSeparator);
                        break;
                    case 'T':
                        builder.Append(_settings.SubComponentSeparator);
                        break;
                    case 'R':
                        builder.Append(_settings.RepetitionSeparator);
                        break;
                    case 'E':
                        builder.Append(_settings.EscapeCharacter);
                        break;

                    case 'X': // if we get empty hex data, skip it as well
                    case 'Z': // locally defined we pass through
                        break;

                    case 'H': // we don't translate highlighting, so just skip it
                    case 'N':
                    default:
                        body.AppendTo(builder, new TextSpan(span.Start, 3));
                        break;
                }

                return span.Start + 3;
            }

            // while we could strip this out, it seems like there would be no other way to get
            // access to this data, so I think it makes sense to leave it in the text and let
            // the application deal with it since it may want to use it.
            if (key == 'X' || key == 'Z' || key == '.') // hexadecimal data or locally defined data
            {
                int end = body.IndexOf(_settings.EscapeCharacter, new TextSpan(span.Start + 2, span.Length - 2));
                if (end > 0)
                {
                    body.AppendTo(builder, TextSpan.FromBounds(span.Start, end + 1));

                    return end + 1;
                }
            }

            body.AppendTo(builder, new TextSpan(span.Start, 1));
            return span.Start + 1;
        }
    }
}