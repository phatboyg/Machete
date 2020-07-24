namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSACMap :
        X12LayoutMap<LoopSAC, X12Entity>
    {
        public LoopSACMap()
        {
            Id = "Loop_SAC";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
        }
    }
}