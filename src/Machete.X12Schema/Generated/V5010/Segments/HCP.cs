namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface HCP : X12Segment
    {
        Value<string> PricingMethodology { get; }

        Value<decimal> RepricedAllowedAmount { get; }

        Value<decimal> RepricedSavingAmount { get; }

        Value<string> RepricingOrganizationIdentifier { get; }

        Value<decimal> RepricingPerDiem { get; }

        Value<string> RepricedApprovedDrgCode { get; }

        Value<decimal> RepricedApprovedAmount { get; }

        Value<string> RepricedApprovedRevenueCode { get; }

        Value<string> ProductQualifier { get; }

        Value<string> RepricedApprovedHcpcsCode { get; }

        Value<string> UnitForMeasurementCode { get; }

        Value<decimal> RepricedApprovedServiceUnitCount { get; }

        Value<string> RejectReasonCode { get; }

        Value<string> PolicyComplianceCode { get; }

        Value<string> ExceptionCode { get; }
    }
}