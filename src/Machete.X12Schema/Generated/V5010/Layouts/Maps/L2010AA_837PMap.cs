namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010AA_837PMap :
        X12LayoutMap<L2010AA_837P, X12Entity>
    {
        public L2010AA_837PMap()
        {
            Id = "2010AA";
            Name = "Billing Provider Name";
            
            Segment(x => x.BillingProvider, 0, x => x.IsRequired());
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.TaxIdNumber, 3, x => x.IsRequired());
            Segment(x => x.LicenseInformation, 4);
            Segment(x => x.ContactInformation, 5);
        }
    }
}