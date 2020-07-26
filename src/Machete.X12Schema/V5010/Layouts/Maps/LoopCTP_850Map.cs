namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCTP_850Map :
        X12LayoutMap<LoopCTP_850, X12Entity>
    {
        public LoopCTP_850Map()
        {
            Id = "Loop_CTP_850";
            Name = "Loop CTP";
            
            Segment(x => x.PricingInformation, 1);
            Segment(x => x.Currency, 2);
        }
    }
}