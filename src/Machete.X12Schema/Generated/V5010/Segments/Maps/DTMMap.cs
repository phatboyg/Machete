namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class DTMMap : X12SegmentMap<DTM, X12Entity>
    {
        public DTMMap()
        {
            Id = "DTM";
            Name = "Date Time Reference";
            Value(x => x.Qualifier, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.Date, 2, x => x.LongDate().IsRequired());
        }
    }
}