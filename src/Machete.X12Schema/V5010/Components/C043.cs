namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C043 :
        X12Component
    {
        Value<string> HealthcareClaimStatusCategoryCode1 { get; }
        
        Value<string> HealthcareClaimStatusCategoryCode2 { get; }
        
        Value<string> EntityIdentifierCode { get; }
        
        Value<string> CodeListQualifierCode { get; }
    }
}