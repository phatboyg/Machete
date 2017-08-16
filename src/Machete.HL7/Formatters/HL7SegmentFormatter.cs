namespace Machete.HL7.Formatters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;


    public class HL7SegmentFormatter<TSegment, TSchema> :
        IEntityFormatter<TSegment>
        where TSegment : TSchema, HL7Segment
        where TSchema : Entity
    {
        readonly HL7FormatterSettings _settings;
        readonly IEntityPropertyFormatter<TSegment>[] _formatters;

        public HL7SegmentFormatter(IEnumerable<IEntityPropertyFormatter<TSegment>> formatters)
        {
            _formatters = formatters.ToArray();

            _settings = new HL7FormatterSettings();
        }

        public void Format(FormatContext context, TSegment entity)
        {
            int length = 0;
            string tag = entity.SegmentId.Value;

            for (int i = 0; i < _formatters.Length; i++)
            {
                if (i > 0)
                {
                    context.Append(_settings.FieldSeparator);
                }

                if (i == 1 && tag == "MSH")
                {
                    context.Append(_settings.ComponentSeparator);
                    context.Append(_settings.RepetitionSeparator);
                    context.Append(_settings.EscapeCharacter);
                    context.Append(_settings.SubComponentSeparator);
                    length = context.Position;
                    continue;
                }

                int position = context.Position;

                _formatters[i].Format(context, entity);

                if (position < context.Position)
                    length = context.Position;
            }

            if (length == 0)
                context.Clear();
            else
            {
                context.Trim(length);
            }
        }

        public void Format<T>(FormatContext context, T entity)
            where T : Entity
        {
            var obj = (object) entity;
            if (obj is TSegment)
            {
                Format(context, (TSegment) obj);
            }
            else
                throw new ArgumentException($"Argument entity type was {TypeCache.GetShortName(entity.GetType())}, expected {TypeCache<TSegment>.ShortName}");
        }

        public Type EntityType => typeof(TSegment);
    }
}