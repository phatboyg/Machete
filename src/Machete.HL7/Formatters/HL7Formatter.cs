namespace Machete.HL7.Formatters
{
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Extensions;


    public class HL7Formatter<TSchema> :
        IFormatter<TSchema>
        where TSchema : HL7Entity
    {
        readonly ISchema<TSchema> _schema;
        readonly HL7FormatterSettings _settings;

        public HL7Formatter(ISchema<TSchema> schema)
        {
            _schema = schema;

            _settings = new HL7FormatterSettings();
        }

        public async Task<FormatResult<TSchema>> FormatAsync(Stream output, EntityResult<TSchema> input)
        {
            using (var writer = new StreamWriter(output))
            {
                for (int i = 0;; i++)
                {
                    TSchema entity;
                    if (!input.TryGetEntity(i, out entity))
                        break;

                    HL7Segment segment = entity as HL7Segment;
                    if (segment == null)
                        throw new MacheteSchemaException($"The entity is not an HL7 segment: {TypeCache.GetShortName(entity.GetType())}");

                    if (i > 0)
                        await writer.WriteAsync(_settings.SegmentSeparator);

                    IEntityFormatter entityFormatter;
                    if (_schema.TryGetEntityFormatter(entity, out entityFormatter))
                    {
                        var context = new StringBuilderFormatContext();

                        entityFormatter.Format(context, entity);

                        await writer.WriteAsync(context.ToString()).ConfigureAwait(false);
                    }
                    else
                    {
                        throw new MacheteSchemaException($"The entity type was not found: {TypeCache.GetShortName(entity.GetType())}");
                    }
                }
            }

            return new HL7FormatResult<TSchema>();
        }

        Task FormatSegment(StreamWriter writer, TSchema entity, HL7Segment segment)
        {
            var builder = new StringBuilder();
            int length = 0;
            string tag = null;

            for (int i = 0;; i++)
            {
                Value<string> field;
                if (!segment.Fields.TryGetValue(i, out field))
                    break;

                if (i > 0)
                    builder.Append(_settings.FieldSeparator);
                else
                    tag = field.Value;

                if (i == 1 && tag == "MSH")
                {
                    builder.Append(_settings.ComponentSeparator);
                    builder.Append(_settings.RepetitionSeparator);
                    builder.Append(_settings.EscapeCharacter);
                    builder.Append(_settings.SubComponentSeparator);
                    length = builder.Length;
                    continue;
                }

                int position = builder.Length;
                field.Slice.SourceText.AppendTo(builder, field.Slice.SourceSpan);
                if (position < builder.Length)
                    length = builder.Length;

//                var parsedSection = field.Slice as TextSlice;
//                if (parsedSection != null)
//                {
//                    builder.Append(parsedSection.Text);
//                }
//                else
//                {
//                    Section repeatingContainer = null;
//                    var repeating = field as RepeatingSection;
//                    if (repeating != null)
//                    {
//                        if (repeating.TryGetRepeating(out repeatingContainer))
//                        {
//                        }
//                    }
//
//                    if (repeatingContainer != null)
//                    {
//                        int position = builder.Length;
//                        FormatRepeating(builder, repeatingContainer);
//                        if (position < builder.Length)
//                            length = builder.Length;
//                    }
//                    else
//                    {
//                        int position = builder.Length;
//                        FormatField(builder, field);
//                        if (position < builder.Length)
//                            length = builder.Length;
//                    }
//                }
            }

            if (length > 0)
                writer.Write(builder.ToString(0, length));

            return TaskUtil.Completed;
        }
    }
}