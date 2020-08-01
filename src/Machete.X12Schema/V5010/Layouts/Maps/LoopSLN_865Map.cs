namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLN_865Map :
        X12LayoutMap<LoopSLN_865, X12Entity>
    {
        public LoopSLN_865Map()
        {
            Id = "Loop_SLN_865";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Segment(x => x.Text, 1);
            Segment(x => x.ServiceCharacteristicIdentification, 2);
            Segment(x => x.ProductOrITemDescription, 3);
            Segment(x => x.AdditionalItemDetail, 4);
            Segment(x => x.Measurements, 5);
            Segment(x => x.PricingInformation, 6);
            Segment(x => x.PeriodAmount, 7);
            Segment(x => x.LineItemAcknowledgement, 8);
            Layout(x => x.LoopSAC, 9);
            Segment(x => x.DateOrTimeReference, 10);
            Segment(x => x.ItemPhysicalDetails, 11);
            Segment(x => x.TaxReference, 12);
            Segment(x => x.AdvertisingDemographicInformation, 13);
            Layout(x => x.LoopQTY, 14);
            Layout(x => x.LoopN9, 15);
            Layout(x => x.LoopN1, 16);
        }
    }
}