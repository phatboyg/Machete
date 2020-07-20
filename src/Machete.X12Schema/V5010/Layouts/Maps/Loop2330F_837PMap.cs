namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330F_837PMap :
        X12LayoutMap<Loop2330F_837P, X12Entity>
    {
        public Loop2330F_837PMap()
        {
            Id = "Loop_2330F_837P";
            Name = "Other Payer Supervising Provider";
            
            Segment(x => x.OtherPayerSupervisingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("DQ")));
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}