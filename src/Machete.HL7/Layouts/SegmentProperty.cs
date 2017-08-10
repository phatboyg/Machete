namespace Machete.HL7.Layouts
{
    using System;


    public class SegmentProperty<TSegment> :
        Segment<TSegment>
        where TSegment : HL7Segment
    {
        readonly Entity<TSegment> _entity;

        public SegmentProperty(Entity<TSegment> entity)
        {
            _entity = entity;
        }

        Type IEntity.EntityType => _entity.EntityType;

        bool IEntity.IsPresent => _entity.IsPresent;

        bool IEntity.HasValue => _entity.HasValue;

        TSegment Entity<TSegment>.Value => _entity.Value;
    }
}