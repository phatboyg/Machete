namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2100_997ACK :
        X12Layout
    {
        Segment<AK3> ErrorIdentification { get; }
        
        SegmentList<AK4> DateElementNote { get; }
    }
}