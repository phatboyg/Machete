namespace Machete.X12.Segments
{
    using System;
    using Exceptions;


    public class MissingSegment<TSegment> :
        Segment<TSegment>
        where TSegment : X12Segment
    {
        public Type EntityType => typeof(TSegment);
        public bool IsPresent => false;
        public bool HasValue => false;

        public TSegment Value => throw new SegmentMissingException("The segment is missing.");
    }
}