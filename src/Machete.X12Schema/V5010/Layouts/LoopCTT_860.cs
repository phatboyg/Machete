namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopCTT_860 :
        X12Layout
    {
        Segment<CTT> TransactionTotals { get; }
        
        Segment<AMT> MonetaryAmountInformation { get; }
    }
}