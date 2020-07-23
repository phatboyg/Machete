namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BPRMap :
        X12SegmentMap<BPR, X12Entity>
    {
        public BPRMap()
        {
            Id = "BPR";
            Name = "Financial Information";
            
            Value(x => x.TransactionHandlingCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.MonetaryAmount, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.CreditOrDebitFlagCode, 3, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.PaymentMethodCode, 4, x => x.FixedLength(3).IsRequired());
            Value(x => x.PaymentFormatCode, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumberQualifier1, 6, x => x.FixedLength(2));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumber1, 7, x => x.MinLength(3).MaxLength(12));
            Value(x => x.AccountNumberQualifier1, 8, x => x.MinLength(1).MaxLength(3));
            Value(x => x.AccountNumber1, 9, x => x.MinLength(1).MaxLength(35));
            Value(x => x.OriginatingCompanyIdentifier, 10, x => x.FixedLength(10));
            Value(x => x.OriginatingCompanySupplementalCode, 11, x => x.FixedLength(9));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumberQualifier2, 12, x => x.FixedLength(2));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumber2, 13, x => x.MinLength(3).MaxLength(12));
            Value(x => x.AccountNumberQualifier2, 14, x => x.MinLength(1).MaxLength(3));
            Value(x => x.AccountNumber2, 15, x => x.MinLength(1).MaxLength(35));
            Value(x => x.Date, 16, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.BusinessFunctionCode, 17, x => x.MinLength(1).MaxLength(3));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumberQualifier3, 18, x => x.FixedLength(2));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumber3, 19, x => x.MinLength(3).MaxLength(12));
            Value(x => x.AccountNumberQualifier3, 20, x => x.MinLength(1).MaxLength(3));
            Value(x => x.AccountNumber3, 21, x => x.MinLength(1).MaxLength(35));
        }
    }
}