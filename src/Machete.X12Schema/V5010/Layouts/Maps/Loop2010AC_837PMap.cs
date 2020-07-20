namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010AC_837PMap :
        X12LayoutMap<Loop2010AC_837P, X12Entity>
    {
        public Loop2010AC_837PMap()
        {
            Id = "2010AC";
            Name = "Pay-to Plan Name";
            
            Segment(x => x.PayToPlanName, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("PE")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("2U") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("FY") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("NF")));
            Segment(x => x.TaxIdNumber, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EIB")));
        }
    }
}