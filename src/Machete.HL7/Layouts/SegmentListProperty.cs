namespace Machete.HL7.Layouts
{
    using System;


    public class SegmentListProperty<TEntity> :
        SegmentList<TEntity>
        where TEntity : HL7Entity
    {
        readonly EntityList<TEntity> _entityList;

        public SegmentListProperty(EntityList<TEntity> entityList)
        {
            _entityList = entityList;
        }

        Type IEntity.EntityType => _entityList.EntityType;

        bool IEntity.IsPresent => _entityList.IsPresent;

        bool IEntity.HasValue => _entityList.HasValue;

        Entity<TEntity> EntityList<TEntity>.this[int index] => _entityList[index];

        bool SegmentList<TEntity>.TryGetValue(int index, out Segment<TEntity> segment)
        {
            Entity<TEntity> entityValue;
            if (_entityList.TryGetValue(index, out entityValue))
            {
                segment = new SegmentProperty<TEntity>(entityValue);
                return true;
            }

            segment = null;
            return false;
        }

        Segment<TEntity> SegmentList<TEntity>.this[int index] => new SegmentProperty<TEntity>(_entityList[index]);

        bool EntityList<TEntity>.TryGetValue(int index, out Entity<TEntity> value)
        {
            return _entityList.TryGetValue(index, out value);
        }
    }
}