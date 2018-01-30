namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface AMT :
        X12Segment
    {
        Value<string> AmountQualifierCode { get; }

        Value<decimal> SupplementalInformationAmount { get; }
    }
}