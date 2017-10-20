namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CR2 : X12Segment
    {
        Value<string> PatientConditionCode { get; }

        Value<string> PatientConditionDescription { get; }

        Value<string> PatientConditionDescription2 { get; }

        Value<string> XrayAvailable { get; }
    }
}