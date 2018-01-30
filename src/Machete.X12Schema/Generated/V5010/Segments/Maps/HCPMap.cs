namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class HCPMap :
        X12SegmentMap<HCP, X12Entity>
    {
        public HCPMap()
        {
            Id = "HCP";
            Name = "Health Care Pricing";
            
            Value(x => x.PricingMethodology, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.RepricedAllowedAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.RepricedSavingAmount, 3, x => x.MinLength(1).MaxLength(18));
            Value(x => x.RepricingOrganizationIdentifier, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.RepricingPerDiem, 5, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RepricedApprovedAmbulatoryPatientGroupCode, 6, x => x.MinLength(1).MaxLength(50));
            Value(x => x.RepricedApprovedAmbulatoryPatientGroupAmount, 7, x => x.MinLength(1).MaxLength(18));
            Value(x => x.RepricedApprovedRevenueCode, 8, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductQualifier, 9, x => x.FixedLength(2));
            Value(x => x.RepricedApprovedHcpcsCode, 10, x => x.MinLength(1).MaxLength(48));
            Value(x => x.UnitForMeasurementCode, 11, x => x.FixedLength(2));
            Value(x => x.RepricedApprovedServiceUnitCount, 12, x => x.MinLength(1).MaxLength(15));
            Value(x => x.RejectReasonCode, 13, x => x.FixedLength(2));
            Value(x => x.PolicyComplianceCode, 14, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ExceptionCode, 15, x => x.MinLength(1).MaxLength(2));
        }
    }
}