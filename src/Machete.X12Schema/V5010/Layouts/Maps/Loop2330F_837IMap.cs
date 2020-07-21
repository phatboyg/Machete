namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330F_837IMap :
        X12LayoutMap<Loop2330F_837I, X12Entity>
    {
        public Loop2330F_837IMap()
        {
            Id = "Loop_2330F_837I";
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