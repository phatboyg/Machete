namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330H_837IMap :
        X12LayoutMap<Loop2330H_837I, X12Entity>
    {
        public Loop2330H_837IMap()
        {
            Id = "Loop_2330H_837I";
            Name = "Other Payer Referring Provider";
            
            Segment(x => x.OtherPayerReferringProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("DN")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                                                                            || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                                                                            || p.ReferenceIdentificationQualifier.IsEqualTo("G2")));
        }
    }
}