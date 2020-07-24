namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPCT_820Map :
        X12LayoutMap<LoopPCT_820, X12Entity>
    {
        public LoopPCT_820Map()
        {
            Id = "Loop_PCT_820";
            Name = "Loop PCT";
            
            Segment(x => x.PercentAmounts, 0);
            Segment(x => x.Quantity, 1);
            Layout(x => x.LoopAMT, 2);
        }
    }
}