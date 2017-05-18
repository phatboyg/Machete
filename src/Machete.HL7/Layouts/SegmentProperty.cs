namespace Machete.HL7.Layouts
{
    using System;


    public class SegmentProperty<TEntity> :
        Segment<TEntity>
        where TEntity : HL7Entity
    {
        readonly Entity<TEntity> _entity;

        public SegmentProperty(Entity<TEntity> entity)
        {
            _entity = entity;
        }

        Type IEntity.EntityType => _entity.EntityType;

        bool IEntity.IsPresent => _entity.IsPresent;

        bool IEntity.HasValue => _entity.HasValue;

        TEntity Entity<TEntity>.Value => _entity.Value;
    }
}