namespace Machete.X12Schema.V5010
{
    using X12;


    public interface FA2 :
        X12Segment
    {
        Value<string> BreakdownStructureDetailCode { get; }
        
        Value<string> FinancialInformationCode { get; }
    }
}