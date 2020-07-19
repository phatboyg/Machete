namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310D_837IMap :
        X12LayoutMap<L2310D_837I, X12Entity>
    {
        public L2310D_837IMap()
        {
            Id = "2310D";
            Name = "Rendering Provider Name";
            
            Segment(x => x.RenderingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("82")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}