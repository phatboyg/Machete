namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class DMGMap :
        X12SegmentMap<DMG, X12Entity>
    {
        public DMGMap()
        {
            Id = "DMG";
            Name = "Demographic Information";
            
            Value(x => x.DateTimeFormatQualifier, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.DateOfBirth, 2, x => x.Converter = X12ValueConverters.DateTimePeriod);
            Value(x => x.GenderCode, 3, x => x.FixedLength(1));
        }
    }
}