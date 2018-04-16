namespace Machete.X12.Tests.TestSchema
{
    public interface RelatedCauseInformation :
        X12Component
    {
        Value<string> RelatedCauseCode1 { get; }
        
        Value<string> RelatedCauseCode2 { get; }
        
        Value<string> RelatedCauseCode3 { get; }
        
        Value<string> AutoAccidentStateOrProvinceCode { get; }
        
        Value<string> CountryCode { get; }
    }
}