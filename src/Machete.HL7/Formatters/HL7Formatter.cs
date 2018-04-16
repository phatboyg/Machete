namespace Machete.HL7.Formatters
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
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

        public async Task<FormatResult<TSchema>> FormatAsync(Stream stream, EntityCollection<TSchema> input)
        {
            using (var writer = new StreamWriter(stream))
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

        public async Task<FormatResult<TSchema>> FormatAsync<T>(Stream stream, Layout<T> layout)
            where T : Layout
        {
            using (var writer = new StreamWriter(stream))
            {
                List<PropertyInfo> properties = typeof(T).GetAllProperties()
                    .Where(x => x.PropertyType.HasInterface(typeof(Segment<>))
                                || x.PropertyType.HasInterface(typeof(SegmentList<>))
                                || x.PropertyType.HasInterface(typeof(Layout<>))
                                || x.PropertyType.HasInterface(typeof(LayoutList<>)))
                    .ToList();

                for (var i = 0; i < properties.Count; i++)
                {
                    if (layout == null)
                        break;
                    
//                    properties[i]
                    // get an EntityCollection from the Layout and loop through to get each entity
//                    if (!layout.Entities.TryGetEntity(i, out TSchema entity))
//                        break;
                    
                    var context = new StringBuilderFormatContext();
                    context.AddSettings(_settings);

                    // if the entity is Segment<> then call the FormatSegment function

                    // if the entity is SegmentList<> then iterate over the list calling the FormatSegment function on each Segment<>
                    
                    // if the entity is Layout<> then call the FormatLayout function

                    // if the entity is LayoutList<> then iterate over the list calling the FormatLayout function on each Layout<>

                    if (context.Position > 0)
                        await writer.WriteAsync(context.ToString()).ConfigureAwait(false);
                }
            }

            return new HL7FormatResult<TSchema>();
        }

        async Task FormatSegment(Stream output, FormatContext context, TSchema segment)
        {
            // if the entity is a Segment<> then find the appropriate formatter and call its corresponding Format method
            // Note: calling the Format method understands how to traverse a Segment that has multiple fields already
        }

        void FormatLayout<T>(Stream output, FormatContext context, Layout<T> layout)
            where T : Entity, Layout
        {
            // get an EntityCollection from the Layout and iterate over the list to get each entity
            
            // if the entity is a Layout<> then recursively call this function
            
            // if the entity is a LayoutList<> then iterate over the list calling this function recursively until the entity is either Segment<> or SegmentList<>
            
            // if the entity is a Segment<> then call then FormatSegment function
            
            // if the entity is a SegmentList<> then iterate over the list calling the FormatSegment function on each Segment<>
        }
    }
}