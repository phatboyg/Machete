namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopRYL_820Map :
        X12LayoutMap<LoopRYL_820, X12Entity>
    {
        public LoopRYL_820Map()
        {
            Id = "Loop_RYL_820";
            Name = "Loop RYL";
            
            Segment(x => x.RoyaltyPayment, 0);
            Layout(x => x.LoopAMT, 1);
        }
    }
}