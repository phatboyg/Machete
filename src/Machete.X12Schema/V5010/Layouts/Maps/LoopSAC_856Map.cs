namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_856Map :
        X12LayoutMap<LoopSAC_856, X12Entity>
    {
        public LoopSAC_856Map()
        {
            Id = "Loop_SAC_856";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.Currency, 1);
        }
    }
}