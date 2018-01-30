namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class DTPMap :
        X12SegmentMap<DTP, X12Entity>
    {
        public DTPMap()
        {
            Id = "DTP";
            Name = "Date Time Period";
            
            Value(x => x.DateTimeQualifier, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.DateTimePeriodFormatQualifier, 2, x => x.MinLength(2).MaxLength(3).IsRequired());
            // TODO qualifier 2
            Value(x => x.DateTimePeriod, 3, x => x.IsRequired());
        }
    }
}