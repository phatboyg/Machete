namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330G_837IMap :
        X12LayoutMap<L2330G_837I, X12Entity>
    {
        public L2330G_837IMap()
        {
            Id = "2330G";
            Name = "Other Payer Rendering Provider Name";
            
            Segment(x => x.RenderingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}