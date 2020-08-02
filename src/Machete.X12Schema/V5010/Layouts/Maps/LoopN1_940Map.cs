namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_940Map :
        X12LayoutMap<LoopN1_940, X12Entity>
    {
        public LoopN1_940Map()
        {
            Id = "Loop_N1_940";
            Name = "Loop 0340";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.AdministrativeCommunicationsContact, 4);
        }
    }
}