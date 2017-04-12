namespace Machete.HL7
{
    public interface SegmentList<TSegment> :
        EntityList<TSegment>
        where TSegment : HL7Entity
    {
    }
}