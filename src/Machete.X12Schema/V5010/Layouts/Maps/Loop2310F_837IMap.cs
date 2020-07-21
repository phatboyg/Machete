namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2310F_837IMap :
        X12LayoutMap<Loop2310F_837I, X12Entity>
    {
        public Loop2310F_837IMap()
        {
            Id = "Loop_2310F_837I";
            Name = "Referring Provider Name";
            
            Segment(x => x.ReferringProvider, 0);
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("G2")));
        }
    }
}