namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class TXPMap :
        X12SegmentMap<TXP, X12Entity>
    {
        public TXPMap()
        {
            Id = "TXP";
            Name = "Tax Payment";
            
            Value(x => x.TaxIdentificationNumber, 1, x => x.MinLength(1).MaxLength(20).IsRequired());
            Value(x => x.TaxPaymentTypeCode, 2, x => x.MinLength(1).MaxLength(5).IsRequired());
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TaxInformationIdentificationNumber1, 4, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.TaxAmount1, 5, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.TaxInformationIdentificationNumber2, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TaxAmount2, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.TaxInformationIdentificationNumber3, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TaxAmount3, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.TaxPayerVerification, 3, x => x.MinLength(1).MaxLength(6));
        }
    }
}