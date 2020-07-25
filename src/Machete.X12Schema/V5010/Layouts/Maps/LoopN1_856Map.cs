namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_856Map :
        X12LayoutMap<LoopN1_856, X12Entity>
    {
        public LoopN1_856Map()
        {
            Id = "Loop_N1_1_856";
            Name = "Loop N1";
            
            Segment(x => x.Name, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.AddressInformation, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.ReferenceIdentification, 4);
            Segment(x => x.AdministrativeCommunicationsContact, 5);
            Segment(x => x.FreeOnBoardRelatedInstructions, 6);
        }
    }
}