namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class DADMap :
        X12SegmentMap<DAD, X12Entity>
    {
        public DADMap()
        {
            Id = "DAD";
            Name = "Debit Authorization Detail";
            
            Value(x => x.ActionCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.TransactionHandlingCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.Date1, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.OriginatingCompanyIdentifier, 5, x => x.FixedLength(10));
            Value(x => x.OriginatingCompanySupplementalCode, 6, x => x.FixedLength(9));
            Value(x => x.AmountQualifierCode, 7, x => x.MinLength(1).MaxLength(3));
            Value(x => x.MonetaryAmount, 8, x => x.MinLength(1).MaxLength(18));
            Value(x => x.ReferenceIdentification1, 9, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentification2, 10, x => x.FixedLength(2));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumberQualifier, 11, x => x.FixedLength(2));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumber, 12, x => x.MinLength(3).MaxLength(12));
            Value(x => x.AccountNumber, 13, x => x.MinLength(1).MaxLength(35));
            Value(x => x.Number, 14, x => x.MinLength(3).MaxLength(9));
            Value(x => x.FrequencyCode, 15, x => x.FixedLength(1));
        }
    }
}