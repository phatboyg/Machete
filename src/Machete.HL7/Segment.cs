namespace Machete.HL7
{
    public interface Segment<out TSegment> :
        Entity<TSegment>
        where TSegment : HL7Entity
    {
    }
}