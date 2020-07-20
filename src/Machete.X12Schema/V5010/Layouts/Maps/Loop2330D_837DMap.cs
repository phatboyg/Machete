namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330D_837DMap :
        X12LayoutMap<Loop2330D_837D, X12Entity>
    {
        public Loop2330D_837DMap()
        {
            Id = "2330D";
            Name = "Other Payer Rendering Provider";
            
            Segment(x => x.OtherPayerRenderingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}