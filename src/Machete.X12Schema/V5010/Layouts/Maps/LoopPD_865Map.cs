namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPD_865Map :
        X12LayoutMap<LoopPD_865, X12Entity>
    {
        public LoopPD_865Map()
        {
            Id = "Loop_PD_865";
            Name = "Loop PD";
            
            Segment(x => x.PricingData, 0);
            Segment(x => x.PricingDataDetails, 1);
        }
    }
}