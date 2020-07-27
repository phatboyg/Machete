namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCTP_860Map :
        X12LayoutMap<LoopCTP_860, X12Entity>
    {
        public LoopCTP_860Map()
        {
            Id = "Loop_CTP_860";
            Name = "Loop CTP";
            
            Segment(x => x.PricingInformation, 1);
            Segment(x => x.Currency, 2);
        }
    }
}