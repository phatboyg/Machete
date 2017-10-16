namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface OI : X12Segment
    {
        Value<string> BenefitsAssignmentCertificationIndicator { get; }

        Value<string> ReleaseOfInformationCode { get; }
    }
}