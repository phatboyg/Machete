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

        public async Task<FormatResult<TSchema>> FormatAsync(Stream output, EntityCollection<TSchema> input)
        {
            using (var writer = new StreamWriter(output))
            {
                for (var i = 0;; i++)
                {
                    if (!input.TryGetEntity(i, out TSchema entity))
                        break;

                    if (!(entity is HL7Segment))
                        throw new MacheteSchemaException($"The entity is not an HL7 segment: {TypeCache.GetShortName(entity.GetType())}");

                    if (i > 0)
                        await writer.WriteAsync(_settings.SegmentSeparator).ConfigureAwait(false);

                    if (!_schema.TryGetEntityFormatter(entity, out var entityFormatter))
                        throw new MacheteSchemaException($"An entity formatter for the entity was not found: {TypeCache.GetShortName(entity.GetType())}");

                    var context = new StringBuilderFormatContext();
                    context.AddSettings(_settings);

                    entityFormatter.Format(context, entity);

                    if (context.Position > 0)
                        await writer.WriteAsync(context.ToString()).ConfigureAwait(false);
                }
            }

            return new HL7FormatResult<TSchema>();
        }
    }
}