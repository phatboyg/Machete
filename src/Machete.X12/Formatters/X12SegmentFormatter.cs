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
            var length = 0;

            var entityContext = context.CreateEntityContext(entity);
            var segmentContext = entityContext.SetLevel(FormatLevel.Segment);

            var elementSeparator = segmentContext.Settings.ElementSeparator;

            for (var i = 0; i < _formatters.Length; i++)
            {
                if (i > 0)
                    context.Append(elementSeparator);

                var position = context.Position;

                _formatters[i].Format(entityContext.CreateEntityContext(entity));

                if (position < context.Position)
                    length = context.Position;
            }

            if (length == 0)
                context.Clear();
            else
                context.Trim(length);
        }

        public void Format<T>(FormatContext context, T entity)
            where T : Entity
        {
            var obj = (object) entity;
            if (obj is TSegment segment)
                Format(context, segment);
            else
                throw new ArgumentException($"Argument entity type was {TypeCache.GetShortName(entity.GetType())}, expected {TypeCache<TSegment>.ShortName}");
        }

        public Type EntityType => typeof(TSegment);
    }
}