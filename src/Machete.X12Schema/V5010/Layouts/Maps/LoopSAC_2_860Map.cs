namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_2_860Map :
        X12LayoutMap<LoopSAC_2_860, X12Entity>
    {
        public LoopSAC_2_860Map()
        {
            Id = "Loop_SAC_2_860";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.Currency, 1);
            Segment(x => x.PricingInformation, 2);
        }
    }
}