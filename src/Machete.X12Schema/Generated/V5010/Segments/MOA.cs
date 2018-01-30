namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface MOA :
        X12Segment
    {
        Value<decimal> ReimbursementRate { get; }

        Value<decimal> HCPCSPayableAmount { get; }

        Value<string> ClaimPaymentRemarkCode1 { get; }

        Value<string> ClaimPaymentRemarkCode2 { get; }

        Value<string> ClaimPaymentRemarkCode3 { get; }

        Value<string> ClaimPaymentRemarkCode4 { get; }

        Value<string> ClaimPaymentRemarkCode5 { get; }

        Value<decimal> EndStageRenalDisaesePaymentAmount { get; }

        Value<decimal> NonPayableProfessionalComponentBilledAmount { get; }
    }
}