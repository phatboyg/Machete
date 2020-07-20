namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C023 :
        X12Component
    {
        Value<string> PlaceOfServiceCode { get; }
        
        Value<string> FacilityCodeQualifier { get; }
        
        Value<string> ClaimFrequencyTypeCode { get; }
    }
}