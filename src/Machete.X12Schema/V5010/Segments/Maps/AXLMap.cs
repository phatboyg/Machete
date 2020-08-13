namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class AXLMap :
        X12SegmentMap<AXL, X12Entity>
    {
        public AXLMap()
        {
            Id = "AXL";
            Name = "Vehicle Axle Measurements";
            
            Value(x => x.ProductOrServiceIdQualifier, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ProductOrServiceId, 2, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.MeasurementUnitQualifier, 3, x => x.FixedLength(1));
            Value(x => x.Length, 4, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Width, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.WeightQualifier, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Weight, 7, x => x.MinLength(1).MaxLength(10));
            Value(x => x.ReferenceIdentification, 8, x => x.MinLength(1).MaxLength(50));
        }
    }
}