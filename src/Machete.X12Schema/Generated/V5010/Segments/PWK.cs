namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface PWK :
        X12Segment
    {
        Value<string> AttachmentReportType { get; }

        Value<string> ReportTransmissionCode { get; }

        Value<string> IdentificationCodeQualifier { get; }

        Value<string> AttachmentControlNumber { get; }

        Value<string> AttachmentDescription { get; }
    }
}