namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0300_947 :
        X12Layout
    {
        Segment<W19> TransactionSetLineNumber { get; }
        
        SegmentList<G69> MarksAndNumbersInformation { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        Segment<CS> ContractSummary { get; }
        
        Segment<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        LayoutList<Loop0310_947> Loop0310 { get; }
        
        LayoutList<Loop0320_947> Loop0320 { get; }
        
        LayoutList<Loop0330_947> Loop0330 { get; }
    }
}