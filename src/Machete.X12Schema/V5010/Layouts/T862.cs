namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T862 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BSS> BeginningShippingScheduleOrProductionSequence { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopN1_862> LoopN1 { get; }
        
        LayoutList<LoopLIN_862> LoopLIN { get; }
        
        Segment<CTT> TransactionTotals { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}