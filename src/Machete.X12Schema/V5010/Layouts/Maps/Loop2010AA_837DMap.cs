namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010AA_837DMap :
        X12LayoutMap<Loop2010AA_837D, X12Entity>
    {
        public Loop2010AA_837DMap()
        {
            Id = "Loop_2010AA_837D";
            Name = "Billing Provider Name";
            
            Segment(x => x.BillingProvider, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.TaxIdNumber, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EI") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("SY")));
            Segment(x => x.UPINOrLicenseInformation, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("OB") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("1G")));
            Segment(x => x.ContactInformation, 5);
        }
    }
}