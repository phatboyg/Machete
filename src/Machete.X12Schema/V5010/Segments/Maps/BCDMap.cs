namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BCDMap :
        X12SegmentMap<BCD, X12Entity>
    {
        public BCDMap()
        {
            Id = "BCD";
            Name = "Beginning Credit/Debit Adjustment";
            
            Value(x => x.Date1, 1, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.CreditOrDebitAdjustmentNumber, 2, x => x.MinLength(1).MaxLength(22));
            Value(x => x.TransactionHandlingCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Amount, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.CreditOrDebitFlagCode, 5, x => x.FixedLength(1));
            Value(x => x.Date2, 6, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.InvoiceNumber, 7, x => x.MinLength(1).MaxLength(22));
            Value(x => x.VendorOrderNumber, 8, x => x.MinLength(1).MaxLength(22));
            Value(x => x.Date3, 9, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.PurchaseOrderNumber, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.TransactionSetPurposeCode, 11, x => x.FixedLength(1));
            Value(x => x.TransactionTypeCode, 12, x => x.FixedLength(1));
            Value(x => x.ReferenceIdentificationQualifier, 13, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 14, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ActionCode, 15, x => x.MinLength(1).MaxLength(2));
        }
    }
}