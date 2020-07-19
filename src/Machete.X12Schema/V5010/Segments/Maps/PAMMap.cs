namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class PAMMap :
        X12SegmentMap<PAM, X12Entity>
    {
        public PAMMap()
        {
            Id = "PAM";
            Name = "Period Amount";
            
            Value(x => x.QuantityQualifier, 1, x => x.FixedLength(2));
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Entity(x => x.CompositeUnitOfMeasure, 3);
            Value(x => x.AmountQualifierCode, 4, x => x.MinLength(1).MaxLength(3));
            Value(x => x.MonetaryAmount, 5, x => x.MinLength(1).MaxLength(18));
            Value(x => x.UnitOfTimePeriodOrInterval, 6, x => x.FixedLength(2));
            Value(x => x.DateTimeQualifier1, 7, x => x.FixedLength(3));
            Value(x => x.Date1, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time1, 9, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.VariableTime;
            });
            Value(x => x.DateTimeQualifier2, 10, x => x.FixedLength(3));
            Value(x => x.Date2, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time2, 12, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.VariableTime;
            });
            Value(x => x.PercentQualifier, 13, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PercentageAsDecimal, 14, x => x.MinLength(1).MaxLength(10));
            Value(x => x.YesNoConditionOrResponseCode, 15, x => x.FixedLength(1));
        }
    }
}