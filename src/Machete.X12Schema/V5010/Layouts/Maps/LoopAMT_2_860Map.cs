namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_2_860Map :
        X12LayoutMap<LoopAMT_2_860, X12Entity>
    {
        public LoopAMT_2_860Map()
        {
            Id = "Loop_AMT_2_860";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmountInformation, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.PercentAmounts, 2);
        }
    }
}