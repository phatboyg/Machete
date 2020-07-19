namespace Machete.X12Schema.V5010
{
    using X12;


    public interface FA1 :
        X12Segment
    {
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> ServicePromotionAllowanceOrChargeCode { get; }
        
        Value<string> AllowanceOrChargeIndicator { get; }
    }
}