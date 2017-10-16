namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CL1 : X12Segment
    {
        Value<string> AdmissionTypeCode { get; }

        Value<string> AdmissionSourceCode { get; }

        Value<string> PatientStatusCode { get; }
    }
}