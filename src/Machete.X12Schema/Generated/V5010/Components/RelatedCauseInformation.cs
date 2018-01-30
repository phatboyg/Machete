namespace Machete.X12Schema.V5010.Components
{
    using X12;


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