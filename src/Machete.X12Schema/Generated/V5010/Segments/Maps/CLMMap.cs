namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class CLMMap : X12SegmentMap<CLM, X12Entity>
    {
        public CLMMap()
        {
            Id = "CLM";
            Name = "Claim Information";
            Value(x => x.PatientControlNumber, 1, x => x.MinLength(1).MaxLength(38).IsRequired());
            Value(x => x.TotalClaimCharges, 2, x => x.MinLength(1));
            Value(x => x.TypeOfBill, 5, x => x.MinLength(1));
            Value(x => x.ProviderSignatureOnFile, 6, x => x.FixedLength(1).IsRequired());
            Value(x => x.MedicareAssignmentCode, 7, x => x.FixedLength(1));
            Value(x => x.AssignmentOfBenefitsIndicator, 8, x => x.FixedLength(1));
            Value(x => x.ReleaseOfInformation, 9, x => x.FixedLength(1));
            Value(x => x.RelatedCauses, 11, x => x.MinLength(1));
            Value(x => x.SpecialProgramIndicator, 12, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ExplanationOfBenefits, 18, x => x.FixedLength(1));
            Value(x => x.DelayReason, 20, x => x.MinLength(1).MaxLength(2));
        }
    }
}