namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class W15Map :
        X12SegmentMap<W15, X12Entity>
    {
        public W15Map()
        {
            Id = "W15";
            Name = "Warehouse Adjustment Identification";
            
            Value(x => x.Date, 1, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.AdjustmentNumber1, 2, x => x.MinLength(1).MaxLength(22));
            Value(x => x.AdjustmentNumber2, 3, x => x.MinLength(1).MaxLength(22));
            Value(x => x.TransactionSetPurposeCode, 4, x => x.FixedLength(2).IsRequired());
            Value(x => x.TransactionTypeCode, 5, x => x.FixedLength(2));
            Value(x => x.ActionCode, 6, x => x.MinLength(1).MaxLength(2));
        }
    }
}