namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class SRMap :
        X12SegmentMap<SR, X12Entity>
    {
        public SRMap()
        {
            Id = "SR";
            Name = "Requested Service Schedule";
            
            Value(x => x.AssignedIdentification, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.DayRotation, 2, x => x.MinLength(1).MaxLength(7));
            Value(x => x.Time1, 3, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.Time2, 4, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.FreeFormMessage, 5, x => x.MinLength(1).MaxLength(60));
            Value(x => x.UnitPrice, 6, x => x.MinLength(1).MaxLength(17));
            Value(x => x.Quantity, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Date1, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 9, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ProductOrServiceId1, 10, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceId2, 11, x => x.MinLength(1).MaxLength(48));
        }
    }
}