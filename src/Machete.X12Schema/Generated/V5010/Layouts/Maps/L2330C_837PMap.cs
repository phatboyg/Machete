namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330C_837PMap :
        X12LayoutMap<L2330C_837P, X12Entity>
    {
        public L2330C_837PMap()
        {
            Id = "2330C";
            Name = "Other Payer Referring Provider";

            Segment(x => x.Provider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("DN") ||
                                                               p.EntityIdentifierCode.IsEqualTo("P3")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("G2")));
        }
    }
}