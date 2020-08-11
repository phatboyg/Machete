namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PO4Map :
        X12SegmentMap<PO4, X12Entity>
    {
        public PO4Map()
        {
            Id = "PO4";
            Name = "Item Physical Details";
            
            Value(x => x.Pack, 1, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Size, 2, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode1, 3, x => x.FixedLength(2));
            Value(x => x.PackagingCode, 4, x => x.MinLength(3).MaxLength(5));
            Value(x => x.WeightQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.GrossWeightPerPack, 6, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisForMeasurementCode2, 7, x => x.FixedLength(2));
            Value(x => x.GrossVolumePerPack, 8, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisForMeasurementCode3, 9, x => x.FixedLength(2));
            Value(x => x.Length, 10, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Width, 11, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Height, 12, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode4, 13, x => x.FixedLength(2));
            Value(x => x.InnerPack, 14, x => x.MinLength(1).MaxLength(9));
            Value(x => x.SurfaceLayerOrPositionCode, 15, x => x.MinLength(1).MaxLength(20));
            Value(x => x.AssignedIdentification1, 16, x => x.MinLength(1).MaxLength(20));
            Value(x => x.AssignedIdentification2, 17, x => x.MinLength(1).MaxLength(20));
            Value(x => x.Number, 18, x => x.MinLength(1).MaxLength(9));
        }
    }
}