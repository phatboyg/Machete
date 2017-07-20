namespace Machete.HL7
{
    using System;
    using Exceptions;


    public class MissingSegment<TSegment> :
        Segment<TSegment>
        where TSegment : HL7Entity
    {
        public Type EntityType { get; } = typeof(TSegment);
        public bool IsPresent { get; } = false;
        public bool HasValue { get; } = false;
        public TSegment Value { get { throw new SegmentMissingException("The segment is missing."); } }
    }
}