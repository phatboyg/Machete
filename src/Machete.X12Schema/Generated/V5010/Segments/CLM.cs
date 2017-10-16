namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CLM : X12Segment
    {
        Value<string> PatientControlNumber { get; }

        Value<decimal> TotalClaimCharges { get; }

        Value<string> TypeOfBill { get; }

        Value<string> ProviderSignatureOnFile { get; }

        Value<string> MedicareAssignmentCode { get; }

        Value<string> AssignmentOfBenefitsIndicator { get; }

        Value<string> ReleaseOfInformation { get; }

        Value<string> RelatedCauses { get; }

        Value<string> SpecialProgramIndicator { get; }

        Value<string> ExplanationOfBenefits { get; }

        Value<string> DelayReason { get; }
    }
}