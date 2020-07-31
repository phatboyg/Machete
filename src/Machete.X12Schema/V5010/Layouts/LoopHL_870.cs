namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopHL_870 :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<PRF> PurchaseOrderReference { get; }
        
        LayoutList<LoopISR_1_870> LoopISR { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<CS> ContactSummary { get; }
        
        LayoutList<LoopREF_870> LoopREF { get; }
        
        LayoutList<LoopN1_2_870> LoopN1 { get; }
        
        LayoutList<LoopLM_870> LoopLM { get; }
        
        LayoutList<LoopPO1_870> LoopPO1 { get; }
    }
}