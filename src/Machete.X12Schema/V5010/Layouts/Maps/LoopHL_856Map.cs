namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopHL_856Map :
        X12LayoutMap<LoopHL_856, X12Entity>
    {
        public LoopHL_856Map()
        {
            Id = "Loop_HL_856";
            Name = "Loop HL";
            
            Segment(x => x.HierarchicalLevel, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.ItemDetail, 2);
            Segment(x => x.SublineItemDetail, 3);
            Segment(x => x.PurchaseOrderReference, 4);
            Segment(x => x.ItemPhysicalDetails, 5);
            Segment(x => x.ProductOrItemDescription, 6);
            Segment(x => x.Measurements, 7);
            Segment(x => x.Paperwork, 8);
            Segment(x => x.MarkingPackagingOrLoading, 9);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 10);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 11);
            Segment(x => x.CarrierDetailsEquipment, 12);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 13);
            Segment(x => x.TrailerShipmentDetails, 14);
            Segment(x => x.ReferenceIdentification, 15);
            Segment(x => x.AdministrativeCommunicationsContact, 16);
            Layout(x => x.LoopLH1, 17);
            Layout(x => x.LoopCLD, 18);
            Segment(x => x.MarksAndNumbersInformation, 19);
            Segment(x => x.DateOrTimeReference, 20);
            Segment(x => x.FreeOnBoardRelatedInstructions, 21);
            Segment(x => x.PalletTypeAndLoadCharacteristics, 22);
            Layout(x => x.LoopN1, 23);
            Segment(x => x.DestinationQuantity, 24);
            Segment(x => x.ExcessTransportationDetail, 25);
            Segment(x => x.Currency, 26);
            Layout(x => x.LoopSAC, 27);
            Segment(x => x.FurnishedGoodsAndServices, 28);
            Segment(x => x.YesOrNoQuestion, 29);
            Layout(x => x.LoopLM, 30);
            Layout(x => x.LoopV1, 31);
        }
    }
}