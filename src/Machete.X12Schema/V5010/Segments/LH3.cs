namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LH3 :
        X12Segment
    {
        Value<string> HazardousMaterialShippingName { get; }
        
        Value<string> HazardousMaterialShippingNameQualifier { get; }
        
        Value<string> NotOtherwiseSpecifiedIndicatorCode { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}