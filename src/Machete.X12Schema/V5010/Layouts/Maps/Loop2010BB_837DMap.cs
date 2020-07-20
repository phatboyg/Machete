namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010BB_837DMap :
        X12LayoutMap<Loop2010BB_837D, X12Entity>
    {
        public Loop2010BB_837DMap()
        {
            Id = "2010BB";
            Name = "Payer Name";
            
            Segment(x => x.Payer, 0, x => x.IsRequired());
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("2U") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("EI") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("FY") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("NF")));
            Segment(x => x.BillingProviderSecondaryIdentification, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}