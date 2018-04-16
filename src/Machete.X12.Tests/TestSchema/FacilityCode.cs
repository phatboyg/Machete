namespace Machete.X12.Tests.TestSchema
{
    public interface FacilityCode :
        X12Component
    {
        Value<string> PlaceOfServiceCode { get; }
        
        Value<string> FacilityCodeQualifier { get; }
        
        Value<string> ClaimFrequencyTypeCode { get; }
    }
}