﻿namespace Machete.X12.Formatters
{
    using System.IO;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Machete.Formatters;


    public class X12Formatter<TSchema> :
        IFormatter<TSchema>
        where TSchema : X12Entity
    {
        readonly ISchema<TSchema> _schema;
        readonly X12FormatterSettings _settings;

        public X12Formatter(ISchema<TSchema> schema)
        {
            _schema = schema;

            _settings = new X12FormatterSettings();
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

                    X12Segment segment = entity as X12Segment;
                    if (segment == null)
                        throw new MacheteSchemaException($"The entity is not an X12 segment: {TypeCache.GetShortName(entity.GetType())}");

                    if (i > 0)
                        await writer.WriteAsync(_settings.SegmentSeparator);

                    if (_schema.TryGetEntityFormatter(entity, out var entityFormatter))
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