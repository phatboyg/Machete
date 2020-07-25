namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TD4 :
        X12Segment
    {
        Value<string> SpecialHandlingCode { get; }
        
        Value<string> HazardousMaterialCodeQualifier { get; }
        
        Value<string> HazardousMaterialClassCode { get; }
        
        Value<string> Description { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}