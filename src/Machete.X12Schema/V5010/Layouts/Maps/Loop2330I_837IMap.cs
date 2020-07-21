namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330I_837IMap :
        X12LayoutMap<Loop2330I_837I, X12Entity>
    {
        public Loop2330I_837IMap()
        {
            Id = "Loop_2330I_837I";
            Name = "Other Payer Billing Provider";
            
            Segment(x => x.OtherPayerBillingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("85")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}