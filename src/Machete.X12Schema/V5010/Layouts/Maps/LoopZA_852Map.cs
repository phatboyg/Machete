namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopZA_852Map :
        X12LayoutMap<LoopZA_852, X12Entity>
    {
        public LoopZA_852Map()
        {
            Id = "Loop_ZA_852";
            Name = "Loop ZA";  
            
            Segment(x => x.ProductActivityReporting, 0);
            Segment(x => x.QuantityInformation, 1);
            Segment(x => x.PricingInformation, 2);
            Segment(x => x.DestinationQuantity, 3);
            Layout(x => x.LoopG95, 4);
        }
    }
}