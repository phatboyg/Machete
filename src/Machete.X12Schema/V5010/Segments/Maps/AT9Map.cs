namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AT9Map :
        X12SegmentMap<AT9, X12Entity>
    {
        public AT9Map()
        {
            Id = "AT9";
            Name = "Trailer or Container Dimension and Weight";
            
            Value(x => x.EquipmentLength, 1, x => x.MinLength(4).MaxLength(5));
            Value(x => x.Height, 2, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Width, 3, x => x.MinLength(1).MaxLength(8));
            Value(x => x.WeightQualifier, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode, 5, x => x.FixedLength(1));
            Value(x => x.Weight, 6, x => x.MinLength(1).MaxLength(10));
            Value(x => x.VolumeUnitQualifier, 7, x => x.FixedLength(5));
            Value(x => x.Volume, 8, x => x.MinLength(1).MaxLength(8));
        }
    }
}