namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2120C_271Map :
        X12LayoutMap<L2120C_271, X12Entity>
    {
        public L2120C_271Map()
        {
            Id = "2120C";
            Name = "Subscriber Benefite Related Entity Name";
            
            Segment(x => x.BenefitRelatedEntity, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.ContactInformation, 3);
            Segment(x => x.ProviderInformation, 4);
        }
    }
}