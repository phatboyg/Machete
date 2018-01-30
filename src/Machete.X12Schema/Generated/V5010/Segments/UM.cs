namespace Machete.X12Schema.V5010
{
    using Components;
    using X12;


    public interface UM :
        X12Segment
    {
        Value<string> RequestCategoryCode { get; }
        
        Value<string> CertificateTypeCode { get; }
        
        Value<string> ServiceTypeCode { get; }
        
        Value<FacilityCode> HealthCareServiceLocationInformation { get; }
    }
}