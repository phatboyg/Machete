namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330G_837PMap :
        X12LayoutMap<Loop2330G_837P, X12Entity>
    {
        public Loop2330G_837PMap()
        {
            Id = "Loop_2330G_837P";
            Name = "Other Payer Billing Provider";
            
            Segment(x => x.OtherPayerBillingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("85")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.IsRequired().Condition = parser => parser.Where(p =>
                    p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                    p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}