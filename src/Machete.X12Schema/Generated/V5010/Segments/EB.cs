namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface EB :
        X12Segment
    {
        Value<string> EligibilityOrBenefitInformationCode { get; }

        Value<string> CoverageLevelCode { get; }

        Value<string> ServiceTypeCode { get; }

        Value<string> InsuranceTypeCode { get; }

        Value<string> PlanCoverageDescription { get; }

        Value<string> TimePeriodQualifier { get; }

        Value<decimal> MonetaryAmount { get; }

        Value<decimal> Percent { get; }

        Value<string> QuantityQualifier { get; }

        Value<decimal> Quantity { get; }

        Value<string> ConditionOrResponseCode1 { get; }

        Value<string> ConditionOrResponseCode2 { get; }

        Value<string> CompositeMedicalProcedureIdentifier { get; }
    }
}