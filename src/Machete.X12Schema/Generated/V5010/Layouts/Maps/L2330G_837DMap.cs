namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330G_837DMap :
        X12LayoutMap<L2330G_837D, X12Entity>
    {
        public L2330G_837DMap()
        {
            Id = "2330G";
            Name = "Other Payer Service Facility Location";
            
            Segment(x => x.ServiceFacilityLocation, 0);
            Segment(x => x.SecondaryIdentification, 1,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}