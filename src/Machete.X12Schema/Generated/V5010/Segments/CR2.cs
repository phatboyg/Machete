namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CR2 :
        X12Segment
    {
        Value<string> PatientConditionCode { get; }

        Value<string> PatientConditionDescription1 { get; }

        Value<string> PatientConditionDescription2 { get; }

        Value<string> XrayAvailable { get; }
    }
}