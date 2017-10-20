﻿namespace Machete.X12.Layouts
{
    using System;


    public class SegmentListProperty<TSegment> :
        SegmentList<TSegment>
        where TSegment : X12Segment
    {
        readonly EntityList<TSegment> _entityList;

        public SegmentListProperty(EntityList<TSegment> entityList)
        {
            _entityList = entityList;
        }

        Type IEntity.EntityType => _entityList.EntityType;

        bool IEntity.IsPresent => _entityList.IsPresent;

        bool IEntity.HasValue => _entityList.HasValue;

        Entity<TSegment> EntityList<TSegment>.this[int index] => _entityList[index];

        bool SegmentList<TSegment>.TryGetValue(int index, out Segment<TSegment> segment)
        {
            if (_entityList.TryGetValue(index, out var entityValue))
            {
                segment = new SegmentProperty<TSegment>(entityValue);
                return true;
            }

            segment = null;
            return false;
        }

        Segment<TSegment> SegmentList<TSegment>.this[int index] => new SegmentProperty<TSegment>(_entityList[index]);

        bool EntityList<TSegment>.TryGetValue(int index, out Entity<TSegment> value)
        {
            return _entityList.TryGetValue(index, out value);
        }
    }
}