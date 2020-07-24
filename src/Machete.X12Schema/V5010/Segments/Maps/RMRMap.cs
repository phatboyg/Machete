namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RMRMap :
        X12SegmentMap<RMR, X12Entity>
    {
        public RMRMap()
        {
            Id = "RMR";
            Name = "Remittance Advice Accounts Receivable Open Item Reference";
            
            Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PaymentActionCode, 3, x => x.FixedLength(2));
            Value(x => x.MonetaryAmount1, 4, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount2, 5, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount3, 6, x => x.MinLength(1).MaxLength(18));
            Value(x => x.AdjustmentReasonCode, 7, x => x.FixedLength(2));
            Value(x => x.MonetaryAmount4, 8, x => x.MinLength(1).MaxLength(18));
        }
    }
}