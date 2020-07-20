namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010AA_837PMap :
        X12LayoutMap<Loop2010AA_837P, X12Entity>
    {
        public Loop2010AA_837PMap()
        {
            Id = "2010AA";
            Name = "Billing Provider Name";
            
            Segment(x => x.BillingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("85")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.TaxIdNumber, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EI") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("SY")));
            Segment(x => x.UPINOrLicenseInformation, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("O8") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("1G")));
            Segment(x => x.ContactInformation, 5);
        }
    }
}