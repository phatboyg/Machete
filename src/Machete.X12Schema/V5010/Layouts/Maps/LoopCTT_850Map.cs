namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCTT_850Map :
        X12LayoutMap<LoopCTT_850, X12Entity>
    {
        public LoopCTT_850Map()
        {
            Id = "Loop_CTT_850";
            Name = "Loop ADV";
            
            Segment(x => x.TransactionTotals, 0);
            Segment(x => x.MonetaryAmountInformation, 1);
        }
    }
}