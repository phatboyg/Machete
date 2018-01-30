namespace Machete.X12Schema.V5010
{
    using System;
    using X12;

    
    public interface BPR :
        X12Segment
    {
        Value<string> TransactionHandlingCode { get; }

        Value<decimal> TotalActualProviderPaymentAmount { get; }

        Value<string> CreditOrDebitFlagCode { get; }

        Value<string> PaymentMethodCode { get; }

        Value<string> PaymentFormatCode { get; }

        Value<string> SenderDfiIdNumberQualifier { get; }

        Value<string> SenderDfiIdNumber { get; }

        Value<string> SenderAccountNumberQualifier { get; }

        Value<string> SenderAccountNumber { get; }

        Value<string> OriginatingCompanyId { get; }

        Value<string> OriginatingCompanySupplementalCode { get; }

        Value<string> ReceiverDfiIdNumberQualifier { get; }

        Value<string> ReceiverDfiIdNumber { get; }

        Value<string> ReceiverAccountNumberQualifier { get; }

        Value<string> ReceiverAccountNumber { get; }

        Value<DateTime> CheckIssueOrEftEffectiveDate { get; }
    }
}