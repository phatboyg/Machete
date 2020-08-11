namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class FSTMap :
        X12SegmentMap<FST, X12Entity>
    {
        public FSTMap()
        {
            Id = "FST";
            Name = "Forecast Schedule";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.ForecastQualifier, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.TimingQualifier, 3, x => x.FixedLength(1).IsRequired());
            Value(x => x.Date1, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.DateOrTimeQualifier, 6, x => x.FixedLength(3));
            Value(x => x.Time, 7, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.ReferenceIdentificationQualifier, 8, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 9, x => x.MinLength(1).MaxLength(50));
            Value(x => x.PlanningScheduleTypeCode, 10, x => x.FixedLength(2));
            Value(x => x.QuantityQualifier, 11, x => x.FixedLength(2));
            Value(x => x.AdjustmentReasonCode, 12, x => x.FixedLength(2));
            Value(x => x.Description, 13, x => x.MinLength(1).MaxLength(80));
        }
    }
}