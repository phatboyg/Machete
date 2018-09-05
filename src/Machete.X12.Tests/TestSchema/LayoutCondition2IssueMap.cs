namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class LayoutCondition2IssueMap :
        X12LayoutMap<LayoutCondition2Issue, X12Entity>
    {
        public LayoutCondition2IssueMap()
        {
            Id = "LayoutConditionIssue";
            Name = "Payer Identification";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
            Segment(x => x.BusinessContactInformation, 3,
                x => x.Condition = parser => parser.Where(p => p.ContactFunctionCode.IsEqualTo("CX")));
            Segment(x => x.TechnicalContactInformation, 4,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ContactFunctionCode.IsEqualTo("BL")));
            Segment(x => x.TransactionSetTrailer, 5, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 6);
            Segment(x => x.InterchangeControlTrailer, 7);
        }
    }
}