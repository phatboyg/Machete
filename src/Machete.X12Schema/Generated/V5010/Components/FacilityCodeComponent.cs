namespace Machete.X12Schema.V5010.Components
{
    using X12;


    public interface FacilityCodeComponent :
        X12Component
    {
        Value<string> FacilityCodeValue { get; }
        Value<string> FacilityCodeQualifier { get; }
        Value<string> ClaimFrequencyTypeCode { get; }
    }
}