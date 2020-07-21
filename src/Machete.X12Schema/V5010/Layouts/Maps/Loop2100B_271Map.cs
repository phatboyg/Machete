namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100B_271Map :
        X12LayoutMap<Loop2100B_271, X12Entity>
    {
        public Loop2100B_271Map()
        {
            Id = "Loop_2100B_271";
            Name = "Information Receiver Name";
            
            Segment(x => x.InformationReceiver, 0);
            Segment(x => x.AdditionalIdentification, 1);
            Segment(x => x.Address, 2);
            Segment(x => x.RequestValidation, 3);
            Segment(x => x.GeographicInformation, 4);
            Segment(x => x.ProviderInformation, 5);
        }
    }
}