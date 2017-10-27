namespace Machete.X12.Layouts
{
    using System;


    public class SegmentProperty<TSegment> :
        Segment<TSegment>
        where TSegment : X12Segment
    {
        readonly Entity<TSegment> _entity;

        public SegmentProperty(Entity<TSegment> entity)
        {
            _entity = entity;
        }

        Type IEntity.EntityType => _entity.EntityType;

        bool IEntity.HasValue => _entity.HasValue;

        TSegment Entity<TSegment>.Value => _entity.Value;
    }
}