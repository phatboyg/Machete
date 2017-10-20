﻿namespace Machete.X12.Segments
{
    using System;
    using Exceptions;


    /// <summary>
    /// A missing value array is used when the source fragment is missing.
    /// </summary>
    /// <typeparam name="TSegment">The value type</typeparam>
    public class MissingSegmentList<TSegment> :
        SegmentList<TSegment>
        where TSegment : X12Segment
    {
        Type IEntity.EntityType => typeof(TSegment);
        bool IEntity.HasValue => false;
        bool IEntity.IsPresent => false;

        public Segment<TSegment> this[int index]
        {
            get { throw new SegmentMissingException("The segment is missing."); }
        }

        bool SegmentList<TSegment>.TryGetValue(int index, out Segment<TSegment> segment)
        {
            throw new ValueMissingException("The segment is missing.");
        }

        bool EntityList<TSegment>.TryGetValue(int index, out Entity<TSegment> value)
        {
            throw new ValueMissingException("The segment is missing.");
        }

        Entity<TSegment> EntityList<TSegment>.this[int index]
        {
            get { throw new ValueMissingException("The segment is missing."); }
        }
    }
}