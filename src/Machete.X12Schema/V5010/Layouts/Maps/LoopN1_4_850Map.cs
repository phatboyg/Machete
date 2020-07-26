namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_4_850Map :
        X12LayoutMap<LoopN1_4_850, X12Entity>
    {
        public LoopN1_4_850Map()
        {
            Id = "Loop_N1_4_850";
            Name = "Loop N1";
            
            Segment(x => x.Name, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.AddressInformation, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.LocationIdComponent, 4);
            Segment(x => x.ReferenceIdentification, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            Segment(x => x.ServiceCharacteristicIdentification, 7);
        }
    }
}