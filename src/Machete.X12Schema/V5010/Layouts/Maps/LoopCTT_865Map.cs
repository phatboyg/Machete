namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCTT_865Map :
        X12LayoutMap<LoopCTT_865, X12Entity>
    {
        public LoopCTT_865Map()
        {
            Id = "Loop_CTT_865";
            Name = "Loop CTT";
            
            Segment(x => x.TransactionTotals, 0);
            Segment(x => x.MonetaryAmountInformation, 1);
        }
    }
}