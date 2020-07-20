namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2310A_837PMap :
        X12LayoutMap<Loop2310A_837P, X12Entity>
    {
        public Loop2310A_837PMap()
        {
            Id = "2310A";
            Name = "Referring Provider Name";
            
            Segment(x => x.ReferringProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("DN") ||
                    p.EntityIdentifierCode.IsEqualTo("P3")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p =>
                    p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                    p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                    p.ReferenceIdentificationQualifier.IsEqualTo("G2")));
        }
    }
}