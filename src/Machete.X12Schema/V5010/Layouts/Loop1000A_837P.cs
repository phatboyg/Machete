namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1000A_837P :
        X12Layout
    {
        Segment<NM1> Submitter { get; }
        
        SegmentList<PER> EDIContactInformation { get; }
    }
}