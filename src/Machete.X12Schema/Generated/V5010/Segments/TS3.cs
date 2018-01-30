namespace Machete.X12Schema.V5010
{
    using System;
    using X12;
    
    
    public interface TS3 :
        X12Segment
    {
        Value<string> ProviderId { get; }

        Value<string> FacilityTypeCode { get; }

        Value<DateTime> FiscalPeriodDate { get; }

        Value<int> TotalClaimCount { get; }

        Value<decimal> TotalClaimCharges { get; }

        Value<decimal> TotalCoveredCharges { get; }

        Value<decimal> TotalNoncoveredCharges { get; }

        Value<decimal> TotalDeniedCharges { get; }

        Value<decimal> TotalProviderPayment { get; }

        Value<decimal> TotalInterest { get; }

        Value<decimal> TotalContractualAdjustments { get; }

        Value<decimal> TotalGrReduction { get; }

        Value<decimal> TotalMspPayerAmount { get; }

        Value<decimal> TotalBloodDeductible { get; }

        Value<decimal> TotalNonlabCharges { get; }

        Value<decimal> TotalCoinsurance { get; }

        Value<decimal> TotalHcpcsReportedCharges { get; }

        Value<decimal> TotalHcpcsPayable { get; }

        Value<decimal> TotalDeductible { get; }

        Value<decimal> TotalProfessionalComponent { get; }

        Value<decimal> TotalMspPatientLiabilityMet { get; }

        Value<decimal> TotalPatientReimbursement { get; }

        Value<int> TotalPipClaimCount { get; }

        Value<decimal> TotalPipAdjustmentAmount { get; }
    }
}