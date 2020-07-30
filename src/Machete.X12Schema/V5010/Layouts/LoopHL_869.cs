namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopHL_869 :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<PRF> PurchaseOrderReference { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<LIN> ItemIdentification { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        SegmentList<DD> DemandDetail { get; }
        
        SegmentList<GF> FurnishedGoodsAndServices { get; }
        
        LayoutList<LoopREF_869> LoopREF { get; }
        
        LayoutList<LoopN1_856> LoopN1 { get; }
        
        LayoutList<LoopLM_869> LoopLM { get; }
        
        LayoutList<LoopFA1_869> LoopFA1 { get; }
    }
}