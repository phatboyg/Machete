namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopNM1_3_820 :
        X12Layout
    {
        Segment<NM1> IndividualOrOrganizationName { get; }
        
        LayoutList<LoopLOC_820> LoopLOC { get; }
        
        LayoutList<LoopASM_820> LoopASM { get; }
    }
}