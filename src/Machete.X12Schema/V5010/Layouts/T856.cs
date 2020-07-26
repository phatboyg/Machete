namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T856 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BSN> BeginningShipNotice { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopHL_856> LoopHL { get; }
        
        Segment<CTT> TransactionTotals { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}