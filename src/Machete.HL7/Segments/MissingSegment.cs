namespace Machete.HL7.Segments
{
    using System;


    public class MissingSegment<TSegment> :
        Segment<TSegment>
        where TSegment : HL7Segment
    {
        public Type EntityType => typeof(TSegment);
        public bool IsPresent => false;
        public bool HasValue => false;

        public TSegment Value
        {
            get { throw new SegmentMissingException("The segment is missing."); }
        }
    }
}