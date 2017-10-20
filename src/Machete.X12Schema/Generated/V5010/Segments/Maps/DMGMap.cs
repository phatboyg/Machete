namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;
    using X12.Values.Converters;


    public class DMGMap : X12SegmentMap<DMG, X12Entity>
    {
        public DMGMap()
        {
            Id = "DMG";
            Name = "Demographic Information";
            Value(x => x.DateTimeFormatQualifier, 1, x => x.MinLength(2).MaxLength(3));
            // TODO qualifier 1
            Value(x => x.Period, 2, x => x.Converter = X12ValueConverters.DateTimePeriod);
            Value(x => x.GenderCode, 3, x => x.FixedLength(1));
        }
    }
}