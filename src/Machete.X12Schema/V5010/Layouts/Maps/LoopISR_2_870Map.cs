namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopISR_2_870Map :
        X12LayoutMap<LoopISR_2_870, X12Entity>
    {
        public LoopISR_2_870Map()
        {
            Id = "Loop_ISR_2_870";
            Name = "Loop ISR";
            
            Segment(x => x.ItemStatusReport, 0);
            Segment(x => x.ProductOrItemDescription, 1);
            Segment(x => x.QuantityInformation, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Segment(x => x.PartyIdentification, 4);
            Segment(x => x.AdditionalNameInformation, 5);
            Segment(x => x.PartyLocation, 6);
            Segment(x => x.GeographicLocation, 7);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 8);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 9);
            Segment(x => x.CarrierDetailsEquipment, 10);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 11);
            Segment(x => x.ReferenceIdentification, 12);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 13);
            Layout(x => x.LoopLM, 14);
        }
    }
}