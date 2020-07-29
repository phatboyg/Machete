namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_855Map :
        X12LayoutMap<LoopSAC_855, X12Entity>
    {
        public LoopSAC_855Map()
        {
            Id = "Loop_SAC_855";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.Currency, 1);
        }
    }
}