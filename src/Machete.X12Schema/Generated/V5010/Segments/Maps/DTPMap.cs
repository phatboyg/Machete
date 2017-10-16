namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class DTPMap : X12SegmentMap<DTP, X12Entity>
    {
        public DTPMap()
        {
            Id = "DTP";
            Name = "Date Time Period";
            Value(x => x.Qualifier, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.FormatQualifier, 2, x => x.MinLength(2).MaxLength(3).IsRequired());
            // TODO qualifier 2
            Value(x => x.Period, 3, x => x.IsRequired());
        }
    }
}