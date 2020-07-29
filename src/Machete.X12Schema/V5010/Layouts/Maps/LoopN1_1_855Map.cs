namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_1_855Map :
        X12LayoutMap<LoopN1_1_855, X12Entity>
    {
        public LoopN1_1_855Map()
        {
            Id = "Loop_N1_1_855";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.IndividualNameStructureComponents, 2);
            Segment(x => x.PartyLocation, 3);
            Segment(x => x.GeographicLocation, 4);
            Segment(x => x.LocationIdComponent, 5);
            Segment(x => x.ReferenceInformation, 6);
            Segment(x => x.AdministrativeCommunicationsContact, 7);
            Segment(x => x.ServiceCharacteristicIdentification, 8);
            Segment(x => x.FreeOnBoardRelatedInstructions, 9);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 10);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 11);
            Segment(x => x.CarrierDetailsEquipment, 12);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 13);
            Segment(x => x.MarkingPackagingOrLoading, 14);
            Segment(x => x.Text, 15);
        }
    }
}