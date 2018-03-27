namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CLPMap :
        X12SegmentMap<CLP, X12Entity>
    {
        public CLPMap()
        {
            Id = "CLP";
            Name = "Claim Level Data";
            
            Value(x => x.PatientControlNumber, 1, x => x.MinLength(1).MaxLength(38).IsRequired());
            Value(x => x.ClaimStatusCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.TotalClaimCharge, 3, x => x.FixedLength(1).IsRequired());
            Value(x => x.TotalClaimPayment, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.PatientResponsibility, 5, x => x.FixedLength(1));
            Value(x => x.ClaimFilingIndicatorCode, 6, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.PayerClaimControlNumber, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.FacilityTypeCode, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ClaimFrequencyCode, 9, x => x.FixedLength(1));
            Value(x => x.CLP10, 10, x => x.FixedLength(1));
            Value(x => x.DrgCode, 11, x => x.MinLength(1).MaxLength(4));
            Value(x => x.DrgWeight, 12, x => x.FixedLength(1));
            Value(x => x.DischargeFraction, 13, x => x.FixedLength(1));
        }
    }
}