namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_810Map :
        X12LayoutMap<LoopSAC_810, X12Entity>
    {
        public LoopSAC_810Map()
        {
            Id = "Loop_SAC_810";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
        }
    }
}