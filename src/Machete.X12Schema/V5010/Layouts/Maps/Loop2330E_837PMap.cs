namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330E_837PMap :
        X12LayoutMap<Loop2330E_837P, X12Entity>
    {
        public Loop2330E_837PMap()
        {
            Id = "2330E";
            Name = "Other Payer Service Facility Location";
            
            Segment(x => x.OtherPayerServiceFacilityLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("77")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}