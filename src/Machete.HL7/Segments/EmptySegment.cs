namespace Machete.HL7.Segments
{
    using System;


    public class EmptySegment<TSegment> :
        Segment<TSegment>
        where TSegment : HL7Segment
    {
        Type IEntity.EntityType => typeof(TSegment);
        public bool IsPresent => true;
        public bool HasValue => false;

        public TSegment Value => throw new SegmentEmptyException("The segment is empty");
    }
}