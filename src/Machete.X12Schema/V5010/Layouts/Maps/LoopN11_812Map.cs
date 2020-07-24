namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN11_812Map :
        X12LayoutMap<LoopN11_812, X12Entity>
    {
        public LoopN11_812Map()
        {
            Id = "Loop_N11_812";
            Name = "Loop N11";
            
            Segment(x => x.Name, 0);
            Segment(x => x.MonetaryAmount, 1);
            Segment(x => x.PercentAmounts, 2);
            Layout(x => x.LoopN1, 3);
        }
    }
}