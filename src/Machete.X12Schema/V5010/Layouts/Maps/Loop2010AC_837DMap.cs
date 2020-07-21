namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010AC_837DMap :
        X12LayoutMap<Loop2010AC_837D, X12Entity>
    {
        public Loop2010AC_837DMap()
        {
            Id = "Loop_2010AC_837D";
            Name = "Pay-to Plan Name";
            
            Segment(x => x.PayToPlanName, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("2U") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("FY") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("NF")));
            Segment(x => x.TaxIdNumber, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EI")));
        }
    }
}