namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_852Map :
        X12LayoutMap<LoopN1_852, X12Entity>
    {
        public LoopN1_852Map()
        {
            Id = "Loop_N1_852";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.FreeOnBoardRelatedInstructions, 4);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 5);
            Segment(x => x.DateOrTimeReference, 6);
            Segment(x => x.ExtendedReferenceInformation, 7);
            Segment(x => x.AdministrativeCommunicationsContact, 8);
        }
    }
}