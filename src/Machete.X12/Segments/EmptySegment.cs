namespace Machete.X12.Segments
{
    using System;
    using Exceptions;


    public class EmptySegment<TSegment> :
        Segment<TSegment>
        where TSegment : X12Segment
    {
        Type IEntity.EntityType => typeof(TSegment);
        public bool IsPresent => true;
        public bool HasValue => false;

        public TSegment Value
        {
            get { throw new SegmentEmptyException("The segment is empty"); }
        }
    }
}