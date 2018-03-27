namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class TS3Map :
        X12SegmentMap<TS3, X12Entity>
    {
        public TS3Map()
        {
            Id = "TS3";
            Name = "Transaction Statistics";
            
            Value(x => x.ProviderId, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.FacilityTypeCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.FiscalPeriodDate, 3, x => x.LongDate().IsRequired());
            Value(x => x.TotalClaimCount, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.TotalClaimCharges, 5, x => x.FixedLength(1).IsRequired());
            Value(x => x.TotalCoveredCharges, 6, x => x.FixedLength(1));
            Value(x => x.TotalNoncoveredCharges, 7, x => x.FixedLength(1));
            Value(x => x.TotalDeniedCharges, 8, x => x.FixedLength(1));
            Value(x => x.TotalProviderPayment, 9, x => x.FixedLength(1));
            Value(x => x.TotalInterest, 10, x => x.FixedLength(1));
            Value(x => x.TotalContractualAdjustments, 11, x => x.FixedLength(1));
            Value(x => x.TotalGrReduction, 12, x => x.FixedLength(1));
            Value(x => x.TotalMspPayerAmount, 13, x => x.FixedLength(1));
            Value(x => x.TotalBloodDeductible, 14, x => x.FixedLength(1));
            Value(x => x.TotalNonlabCharges, 15, x => x.FixedLength(1));
            Value(x => x.TotalCoinsurance, 16, x => x.FixedLength(1));
            Value(x => x.TotalHcpcsReportedCharges, 17, x => x.FixedLength(1));
            Value(x => x.TotalHcpcsPayable, 18, x => x.FixedLength(1));
            Value(x => x.TotalDeductible, 19, x => x.FixedLength(1));
            Value(x => x.TotalProfessionalComponent, 20, x => x.FixedLength(1));
            Value(x => x.TotalMspPatientLiabilityMet, 21, x => x.FixedLength(1));
            Value(x => x.TotalPatientReimbursement, 22, x => x.FixedLength(1));
            Value(x => x.TotalPipClaimCount, 23, x => x.FixedLength(1));
            Value(x => x.TotalPipAdjustmentAmount, 24, x => x.FixedLength(1));
        }
    }
}