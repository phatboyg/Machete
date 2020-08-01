namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class XQMap :
        X12SegmentMap<XQ, X12Entity>
    {
        public XQMap()
        {
            Id = "XQ";
            Name = "Reporting Date/Action";
            
            Value(x => x.TransactionHandlingCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.Date1, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ReferenceIdentification, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.TransactionSetPurposeCode, 5, x => x.FixedLength(2));
        }
    }
}