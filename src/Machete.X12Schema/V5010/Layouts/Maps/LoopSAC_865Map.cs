namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_865Map :
        X12LayoutMap<LoopSAC_865, X12Entity>
    {
        public LoopSAC_865Map()
        {
            Id = "Loop_SAC_865";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.Currency, 1);
        }
    }
}