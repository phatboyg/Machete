namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCTT_860Map :
        X12LayoutMap<LoopCTT_860, X12Entity>
    {
        public LoopCTT_860Map()
        {
            Id = "Loop_CTT_860";
            Name = "Loop CTT";
            
            Segment(x => x.TransactionTotals, 0);
            Segment(x => x.MonetaryAmountInformation, 1);
        }
    }
}