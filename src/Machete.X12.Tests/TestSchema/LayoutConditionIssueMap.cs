namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class LayoutCondition1IssueMap :
        X12LayoutMap<LayoutCondition1Issue, X12Entity>
    {
        public LayoutCondition1IssueMap()
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
            Segment(x => x.PayerWebsite, 5,
                x => x.Condition = parser => parser.Where(p => p.ContactFunctionCode.IsEqualTo("IC")));
            Segment(x => x.TransactionSetTrailer, 6, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 7);
            Segment(x => x.InterchangeControlTrailer, 8);
        }
    }
}