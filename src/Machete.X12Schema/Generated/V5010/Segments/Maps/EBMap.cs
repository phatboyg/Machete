namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class EBMap : X12SegmentMap<EB, X12Entity>
    {
        public EBMap()
        {
            Id = "EB";
            Name = "Eligibility Or Benefit Information";
            Value(x => x.EligibilityOrBenefitInformationCode, 1, x => x.MinLength(1));
            Value(x => x.CoverageLevelCode, 2, x => x.MinLength(1));
            Value(x => x.ServiceTypeCode, 3, x => x.MinLength(1));
            Value(x => x.InsuranceTypeCode, 4, x => x.MinLength(1));
            Value(x => x.PlanCoverageDescription, 5, x => x.MinLength(1));
            Value(x => x.TimePeriodQualifier, 6, x => x.MinLength(1));
            Value(x => x.MonetaryAmount, 7, x => x.MinLength(1));
            Value(x => x.Percent, 8, x => x.MinLength(1));
            Value(x => x.QuantityQualifier, 9, x => x.MinLength(1));
            Value(x => x.Quantity, 10, x => x.MinLength(1));
            Value(x => x.ConditionOrResponseCode1, 11, x => x.MinLength(1));
            Value(x => x.ConditionOrResponseCode2, 12, x => x.MinLength(1));
            Value(x => x.CompositeMedicalProcedureIdentifier, 13, x => x.MinLength(1));
        }
    }
}