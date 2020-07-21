namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2430_837IMap :
        X12LayoutMap<Loop2430_837I, X12Entity>
    {
        public Loop2430_837IMap()
        {
            Id = "Loop_2430_837I";
            Name = "Line Adjudication Information";
                        
            Segment(x => x.LineAdjudicationInformation, 0);
            Segment(x => x.LineAdjustment, 1);
            Segment(x => x.LineCheckOrRemittanceDate, 2);
            Segment(x => x.RemainingPatientLiability, 3,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("EAF")));
        }
    }
}