namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330D_837PMap :
        X12LayoutMap<Loop2330D_837P, X12Entity>
    {
        public Loop2330D_837PMap()
        {
            Id = "2330D";
            Name = "Other Payer Rendering Provider";
            
            Segment(x => x.OtherPayerRenderingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("82")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}