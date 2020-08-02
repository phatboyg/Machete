namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class G62Map :
        X12SegmentMap<G62, X12Entity>
    {
        public G62Map()
        {
            Id = "G62";
            Name = "Date/Time";
            
            Value(x => x.DateQualifier, 1, x => x.FixedLength(2));
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TimeQualifier, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Time, 4, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.TimeCode, 5, x => x.FixedLength(2));
        }
    }
}