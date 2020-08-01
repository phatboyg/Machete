namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopCTT_865 :
        X12Layout
    {
        Segment<CTT> TransactionTotals { get; }
        
        SegmentList<AMT> MonetaryAmountInformation { get; }
    }
}