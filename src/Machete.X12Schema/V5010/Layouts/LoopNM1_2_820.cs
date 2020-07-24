namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopNM1_2_820 :
        X12Layout
    {
        Segment<NM1> IndividualOrOrganizationName { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<G53> MaintenanceType { get; }
        
        LayoutList<LoopAIN> LoopAIN { get; }
        
        LayoutList<LoopPEN_820> LoopPEN { get; }
    }
}