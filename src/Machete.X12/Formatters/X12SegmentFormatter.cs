namespace Machete.X12.Formatters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;
    using Machete.Formatters;


    public class X12SegmentFormatter<TSegment, TSchema> :
        IEntityFormatter<TSegment>
        where TSegment : TSchema, X12Segment
        where TSchema : Entity
    {
        readonly IEntityPropertyFormatter<TSegment>[] _formatters;

        public X12SegmentFormatter(IEnumerable<IEntityPropertyFormatter<TSegment>> formatters)
        {
            _formatters = formatters.ToArray();
        }

        public void Format(FormatContext context, TSegment entity)
        {
            int length = 0;
            string tag = entity.SegmentId.Value;

            var segmentContext = context.CreateEntityContext(entity);
            var formatContext = segmentContext.SetLevel(FormatLevel.Segment);

            var fieldSeparator = formatContext.Settings.ElementSeparator;

            for (int i = 0; i < _formatters.Length; i++)
            {
                if (i > 0)
                {
                    context.Append(fieldSeparator);
                }

                if (i == 1 && tag == "ISA")
                {
                    context.Append(formatContext.Settings.SubElementSeparator);
                    context.Append(formatContext.Settings.RepetitionSeparator);
                    context.Append(formatContext.Settings.SegmentSeparator);
                    length = context.Position;
                    continue;
                }

                int position = context.Position;

                _formatters[i].Format(segmentContext.CreateEntityContext(entity));

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