namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLIN_862Map :
        X12LayoutMap<LoopLIN_862, X12Entity>
    {
        public LoopLIN_862Map()
        {
            Id = "Loop_LIN_862";
            Name = "Loop LIN";  
            
            Segment(x => x.ItemIdentification, 0);
            Segment(x => x.UnitDetail, 1);
            Segment(x => x.MarkingPackagingOrLoading, 2);
            Segment(x => x.ItemPhysicalDetails, 3);
            Segment(x => x.PartReleaseStatus, 4);
            Segment(x => x.ReferenceIdentification, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            Segment(x => x.ShipOrDeliveryPattern, 7);
            Layout(x => x.LoopFST, 8);
            Layout(x => x.LoopSHP, 9);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 10);
            Segment(x => x.CarrierDetailsEquipment, 11);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 12);
        }
    }
}