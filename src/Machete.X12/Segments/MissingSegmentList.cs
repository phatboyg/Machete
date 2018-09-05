namespace Machete.X12.Segments
{
    using System;


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

        public Segment<TSegment> this[int index] => SegmentValue.Missing<TSegment>();

        bool SegmentList<TSegment>.TryGetValue(int index, out Segment<TSegment> segment)
        {
            segment = SegmentValue.Missing<TSegment>();
            return false;
        }

        bool EntityList<TSegment>.TryGetValue(int index, out Entity<TSegment> segment)
        {
            segment = SegmentValue.Missing<TSegment>();
            return false;
        }

        Entity<TSegment> EntityList<TSegment>.this[int index] => SegmentValue.Missing<TSegment>();
    }
}