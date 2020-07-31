namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T870 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BSR> BeginningOrderStatusReport { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopREF_870> LoopREF { get; }
        
        LayoutList<LoopN1_1_870> LoopN1 { get; }
        
        LayoutList<LoopLM_870> LoopLM { get; }
        
        LayoutList<LoopHL_870> LoopHL { get; }
        
        Segment<CTT> TransactionTotals { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}