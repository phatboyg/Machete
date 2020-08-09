namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_861Map :
        X12LayoutMap<LoopN1_861, X12Entity>
    {
        public LoopN1_861Map()
        {
            Id = "Loop_N1_861";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 3);
            Segment(x => x.GeographicLocation, 4);
            Segment(x => x.ReferenceInformation, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            Segment(x => x.FreeOnBoardRelatedInstructions, 7);
        }
    }
}