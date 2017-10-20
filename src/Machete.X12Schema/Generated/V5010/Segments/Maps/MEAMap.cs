namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class MEAMap : X12SegmentMap<MEA, X12Entity>
    {
        public MEAMap()
        {
            Id = "MEA";
            Name = "Measurements";
            Value(x => x.ReferenceIdentificationCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.MeasurementQualifier, 2, x => x.MinLength(1).MaxLength(3).IsRequired());
            // TODO qualifier 2
            Value(x => x.MeasurementValue, 3, x => x.MinLength(1).MaxLength(20).IsRequired());
        }
    }
}