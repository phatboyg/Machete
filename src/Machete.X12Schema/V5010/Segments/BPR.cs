namespace Machete.X12Schema.V5010
{
    using System;
    using X12;

    
    public interface BPR :
        X12Segment
    {
        Value<string> TransactionHandlingCode { get; }

        Value<decimal> MonetaryAmount { get; }

        Value<string> CreditOrDebitFlagCode { get; }

        Value<string> PaymentMethodCode { get; }

        Value<string> PaymentFormatCode { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumberQualifier1 { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumber1 { get; }

        Value<string> AccountNumberQualifier1 { get; }

        Value<string> AccountNumber1 { get; }

        Value<string> OriginatingCompanyIdentifier { get; }

        Value<string> OriginatingCompanySupplementalCode { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumberQualifier2 { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumber2 { get; }

        Value<string> AccountNumberQualifier2 { get; }

        Value<string> AccountNumber2 { get; }

        Value<DateTime> Date { get; }

        Value<string> BusinessFunctionCode { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumberQualifier3 { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumber3 { get; }

        Value<string> AccountNumberQualifier3 { get; }

        Value<string> AccountNumber3 { get; }
    }
}