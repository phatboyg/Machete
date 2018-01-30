namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CLP :
        X12Segment
    {
        Value<string> PatientControlNumber { get; }

        Value<string> ClaimStatusCode { get; }

        Value<decimal> TotalClaimCharge { get; }

        Value<decimal> TotalClaimPayment { get; }

        Value<decimal> PatientResponsibility { get; }

        Value<string> ClaimFilingIndicatorCode { get; }

        Value<string> PayerClaimControlNumber { get; }

        Value<string> FacilityTypeCode { get; }

        Value<string> ClaimFrequencyCode { get; }

        Value<string> CLP10 { get; }

        Value<string> DrgCode { get; }

        Value<decimal> DrgWeight { get; }

        Value<decimal> DischargeFraction { get; }
    }
}