namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class SHPMap :
        X12SegmentMap<SHP, X12Entity>
    {
        public SHPMap()
        {
            Id = "SHP";
            Name = "Shipped/Received Information";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.QuantityQualifier, 2, x => x.FixedLength(2));
            Value(x => x.DateOrTimeQualifier, 3, x => x.FixedLength(3));
            Value(x => x.Date1, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time1, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.Date2, 6, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time2, 7, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
        }
    }
}