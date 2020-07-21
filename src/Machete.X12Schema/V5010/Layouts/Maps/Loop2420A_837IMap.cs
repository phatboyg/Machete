namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2420A_837IMap :
        X12LayoutMap<Loop2420A_837I, X12Entity>
    {
        public Loop2420A_837IMap()
        {
            Id = "Loop_2420A_837I";
            Name = "Operating Physician Name";
            
            Segment(x => x.OperatingPhysician, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("72")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}