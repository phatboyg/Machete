namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2120C_271Map :
        X12LayoutMap<Loop2120C_271, X12Entity>
    {
        public Loop2120C_271Map()
        {
            Id = "Loop_2120C_271";
            Name = "Subscriber Benefit Related Entity Name";
            
            Segment(x => x.BenefitRelatedEntity, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.ContactInformation, 3);
            Segment(x => x.ProviderInformation, 4);
        }
    }
}