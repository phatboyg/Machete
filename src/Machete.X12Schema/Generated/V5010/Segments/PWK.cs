namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface PWK : X12Segment
    {
        Value<string> AttachmentReportType { get; }

        Value<string> AttachmentTransmission { get; }

        Value<string> IdentificationCodeQualifier { get; }

        Value<string> AttachmentControlNumber { get; }

        Value<string> AttachmentDescription { get; }
    }
}