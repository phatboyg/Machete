namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN12_812Map :
        X12LayoutMap<LoopN1_2_812, X12Entity>
    {
        public LoopN12_812Map()
        {
            Id = "Loop_N1_2_812";
            Name = "Loop N1";
            
            Segment(x => x.Name, 0);
            Segment(x => x.MonetaryAmount, 1);
            Segment(x => x.PercentAmounts, 2);
        }
    }
}