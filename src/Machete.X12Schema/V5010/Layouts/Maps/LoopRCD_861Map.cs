namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopRCD_861Map :
        X12LayoutMap<LoopRCD_861, X12Entity>
    {
        public LoopRCD_861Map()
        {
            Id = "Loop_RCD_861";
            Name = "Loop RCD";
            
            Segment(x => x.ReceivingConditions, 0);
            Segment(x => x.ItemDetail, 1);
            Segment(x => x.Currency, 2);
            Segment(x => x.ItemIdentification, 3);
            Segment(x => x.ItemDescription, 4);
            Segment(x => x.ItemPhysicalDetails, 5);
            Segment(x => x.ReferenceInformation, 6);
            Segment(x => x.AdministrativeCommunicationsContact, 7);
            Segment(x => x.DateOrTimeReference, 8);
            Segment(x => x.PurchaseOrderReference, 9);
            Segment(x => x.Measurements, 10);
            Segment(x => x.FreeOnBoardRelatedInstructions, 11);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 12);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 13);
            Segment(x => x.CarrierDetailsEquipment, 14);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 15);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 16);
            Segment(x => x.MarksAndNumbersInformation, 17);
            Layout(x => x.LoopLM, 18);
            Layout(x => x.LoopSLN, 19);
            Layout(x => x.LoopN1, 20);
            Layout(x => x.LoopFA1, 21);
        }
    }
}