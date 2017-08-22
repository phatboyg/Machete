namespace Machete.HL7.Formatters
{
    using System.IO;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Machete.Formatters;


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
                        context.AddSettings(_settings);

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
    }
}