namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class BPRMap :
        X12SegmentMap<BPR, X12Entity>
    {
        public BPRMap()
        {
            Id = "BPR";
            Name = "Financial Information";
            
            Value(x => x.TransactionHandlingCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.TotalActualProviderPaymentAmount, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.CreditOrDebitFlagCode, 3, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.PaymentMethodCode, 4, x => x.FixedLength(3).IsRequired());
            Value(x => x.PaymentFormatCode, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.SenderDfiIdNumberQualifier, 6, x => x.FixedLength(2));
            Value(x => x.SenderDfiIdNumber, 7, x => x.MinLength(3).MaxLength(12));
            Value(x => x.SenderAccountNumberQualifier, 8, x => x.MinLength(1).MaxLength(3));
            Value(x => x.SenderAccountNumber, 9, x => x.MinLength(1).MaxLength(35));
            Value(x => x.OriginatingCompanyId, 10, x => x.FixedLength(10));
            Value(x => x.OriginatingCompanySupplementalCode, 11, x => x.FixedLength(9));
            Value(x => x.ReceiverDfiIdNumberQualifier, 12, x => x.FixedLength(2));
            Value(x => x.ReceiverDfiIdNumber, 13, x => x.MinLength(3).MaxLength(12));
            Value(x => x.ReceiverAccountNumberQualifier, 14, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ReceiverAccountNumber, 15, x => x.MinLength(1).MaxLength(35));
            Value(x => x.CheckIssueOrEftEffectiveDate, 16, x => x.LongDate().IsRequired());
        }
    }
}