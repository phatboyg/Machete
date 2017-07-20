namespace Machete.HL7
{
    using System;
    using Exceptions;


    public class EmptySegment<TSegment> :
        Segment<TSegment>
        where TSegment : HL7Entity
    {
        public Type EntityType { get; } = typeof(TSegment);
        public bool IsPresent { get; } = true;
        public bool HasValue { get; } = false;
        public TSegment Value { get { throw new SegmentEmptyException("The segment is empty"); } }
    }
}