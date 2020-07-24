namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PYD :
        X12Segment
    {
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> FrequencyCode { get; }
        
        Value<string> TaxTreatmentCode { get; }
        
        Value<string> DeductionTypeCode { get; }
        
        Value<string> Description { get; }
    }
}