namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2310A_837IMap :
        X12LayoutMap<Loop2310A_837I, X12Entity>
    {
        public Loop2310A_837IMap()
        {
            Id = "Loop_2310A_837I";
            Name = "Attending Provider Name";
            
            Segment(x => x.AttendingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("71")));
            Segment(x => x.SpecialtyInformation, 1);
            Segment(x => x.SecondaryIdentification, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("OB")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}