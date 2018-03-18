namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L1000A_837D :
        X12Layout
    {
        Segment<NM1> Name { get; }
        
        SegmentList<PER> EDIContactInformation { get; }
    }
}