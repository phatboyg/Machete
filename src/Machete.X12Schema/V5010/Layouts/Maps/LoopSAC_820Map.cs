namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_820Map :
        X12LayoutMap<LoopSAC_820, X12Entity>
    {
        public LoopSAC_820Map()
        {
            Id = "Loop_SAC_820";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.TaxInformation, 1);
        }
    }
}