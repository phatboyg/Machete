namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class MEAMap :
        X12SegmentMap<MEA, X12Entity>
    {
        public MEAMap()
        {
            Id = "MEA";
            Name = "Measurements";
            
            Value(x => x.MeasurementReferenceIdentificationCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.MeasurementQualifier, 2, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.MeasurementValue, 3, x => x.MinLength(1).MaxLength(20).IsRequired());
        }
    }
}