namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class MOAMap :
        X12SegmentMap<MOA, X12Entity>
    {
        public MOAMap()
        {
            Id = "MOA";
            Name = "Medicare Outpatient Adjudication";
            
            Value(x => x.ReimbursementRate, 1, x => x.MinLength(1).MaxLength(10));
            Value(x => x.HCPCSPayableAmount, 2, x => x.MinLength(1).MaxLength(18));
            Value(x => x.ClaimPaymentRemarkCode1, 3, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ClaimPaymentRemarkCode2, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ClaimPaymentRemarkCode3, 5, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ClaimPaymentRemarkCode4, 6, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ClaimPaymentRemarkCode5, 7, x => x.MinLength(1).MaxLength(50));
            Value(x => x.EndStageRenalDisaesePaymentAmount, 8, x => x.MinLength(1).MaxLength(18));
            Value(x => x.NonPayableProfessionalComponentBilledAmount, 9, x => x.MinLength(1).MaxLength(18));
        }
    }
}