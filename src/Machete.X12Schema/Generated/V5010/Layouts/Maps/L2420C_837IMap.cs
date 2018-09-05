namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420C_837IMap :
        X12LayoutMap<L2420C_837I, X12Entity>
    {
        public L2420C_837IMap()
        {
            Id = "2420C";
            Name = "Rendering Provider Name";
            
            Segment(x => x.ProviderName, 0);
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}