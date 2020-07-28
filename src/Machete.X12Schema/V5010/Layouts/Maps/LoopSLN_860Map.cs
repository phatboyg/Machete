namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLN_860Map :
        X12LayoutMap<LoopSLN_860, X12Entity>
    {
        public LoopSLN_860Map()
        {
            Id = "Loop_SLN_860";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Segment(x => x.Text, 1);
            Segment(x => x.ServiceCharacteristicIdentification, 2);
            Segment(x => x.ProductOrITemDescription, 3);
            Segment(x => x.AdditionalItemDetail, 4);
            Segment(x => x.Commodity, 5);
            Layout(x => x.LoopSAC, 6);
            Segment(x => x.DateOrTimeReference, 7);
            Segment(x => x.PricingInformation, 8);
            Segment(x => x.PeriodAmount, 9);
            Segment(x => x.ItemPhysicalDetails, 10);
            Segment(x => x.TaxReference, 11);
            Segment(x => x.AdvertisingDemographicInformation, 12);
            Layout(x => x.LoopQTY, 13);
            Layout(x => x.LoopN9, 14);
            Layout(x => x.LoopN1, 15);
        }
    }
}