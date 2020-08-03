namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W12Map :
        X12SegmentMap<W12, X12Entity>
    {
        public W12Map()
        {
            Id = "W12";
            Name = "Warehouse Item Detail";
            
            Value(x => x.ShipmentOrOrderStatusCode, 1, x => x.FixedLength(2));
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.NumberOfUnitsShipped, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.QuantityDifference, 4, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisOfMeasurementCode, 5, x => x.FixedLength(2));
            Value(x => x.UniversalProductCodeCaseCode1, 6, x => x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier1, 7, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 8, x => x.MinLength(1).MaxLength(48));
            Value(x => x.WarehouseLotNumber, 9, x => x.MinLength(1).MaxLength(12));
            Value(x => x.Weight1, 10, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier1, 11, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode1, 12, x => x.FixedLength(1));
            Value(x => x.Weight2, 13, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier2, 14, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode2, 15, x => x.FixedLength(1));
            Value(x => x.UniversalProductCodeCaseCode2, 16, x => x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier2, 17, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 18, x => x.MinLength(1).MaxLength(48));
            Value(x => x.LineItemChangeReasonCode, 19, x => x.FixedLength(2));
            Value(x => x.WarehouseDetailAdjustmentIdentifier, 20, x => x.FixedLength(1));
            Value(x => x.ProductOrServiceIdQualifier3, 21, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 22, x => x.MinLength(1).MaxLength(48));
        }
    }
}