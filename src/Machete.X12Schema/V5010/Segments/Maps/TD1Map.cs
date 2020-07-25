namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TD1Map :
        X12SegmentMap<TD1, X12Entity>
    {
        public TD1Map()
        {
            Id = "TD1";
            Name = "Carrier Details (Quantity and Weight)";
            
            Value(x => x.PackagingCode, 1, x => x.MinLength(3).MaxLength(5));
            Value(x => x.LadingQuantity, 2, x => x.MinLength(1).MaxLength(7));
            Value(x => x.CommodityCodeQualifier, 3, x => x.FixedLength(1));
            Value(x => x.CommodityCode, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Description, 5, x => x.MinLength(1).MaxLength(50));
            Value(x => x.WeightQualifier, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Weight, 7, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode1, 8, x => x.FixedLength(2));
            Value(x => x.Volume, 9, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode2, 10, x => x.FixedLength(2));
        }
    }
}