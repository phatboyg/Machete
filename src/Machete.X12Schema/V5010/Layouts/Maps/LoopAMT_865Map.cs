namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_865Map :
        X12LayoutMap<LoopAMT_865, X12Entity>
    {
        public LoopAMT_865Map()
        {
            Id = "Loop_AMT_865";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmountInformation, 0);
            Segment(x => x.PercentAmounts, 1);
        }
    }
}