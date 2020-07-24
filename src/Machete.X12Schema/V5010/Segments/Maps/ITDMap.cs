namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class ITDMap :
        X12SegmentMap<ITD, X12Entity>
    {
        public ITDMap()
        {
            Id = "ITD";
            Name = "Terms of Sale/Deferred Terms of Sale";
            
            Value(x => x.TermsTypeCode, 1, x => x.FixedLength(2));
            Value(x => x.TermsBasisDateCode, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TermsDiscountPercentage, 3, x => x.MinLength(1).MaxLength(6));
            Value(x => x.TermsDiscountDueDate, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TermsDiscountDaysDue, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TermsNetDueDate, 6, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TermsNetDays, 7, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TermsDiscountAmount, 8, x => x.MinLength(1).MaxLength(10));
            Value(x => x.TermsDeferredDueDate, 9, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.DeferredAmountDue, 10, x => x.MinLength(1).MaxLength(10));
            Value(x => x.PercentageOfInvoicePayable, 11, x => x.MinLength(1).MaxLength(5));
            Value(x => x.Description, 12, x => x.MinLength(1).MaxLength(80));
            Value(x => x.DayOfMonth, 13, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PaymentMethodTypeCode, 14, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PercentageAsDecimal, 15, x => x.MinLength(1).MaxLength(10));
        }
    }
}