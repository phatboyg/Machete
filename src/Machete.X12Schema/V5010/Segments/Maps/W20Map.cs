namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W20Map :
        X12SegmentMap<W20, X12Entity>
    {
        public W20Map()
        {
            Id = "W20";
            Name = "Line Item Detail - Packing";
            
            Value(x => x.Pack, 1, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Size, 2, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisOfMeasurementCode1, 3, x => x.FixedLength(2));
            Value(x => x.Weight, 4, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode, 6, x => x.FixedLength(1));
            Value(x => x.UnitWeight, 7, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Volume, 8, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisOfMeasurementCode2, 9, x => x.FixedLength(2));
            Value(x => x.Color, 10, x => x.MinLength(1).MaxLength(10));
        }
    }
}