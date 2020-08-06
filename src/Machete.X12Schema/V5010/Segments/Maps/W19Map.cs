namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W19Map :
        X12SegmentMap<W19, X12Entity>
    {
        public W19Map()
        {
            Id = "W19";
            Name = "Warehouse Adjustment Item Detail";
            
            Value(x => x.QuantityOrStatusAdjustmentReasonCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.CreditOrDebitQuantity, 2, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.UnitOrBasisOfMeasurementCode, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.UniversalProductCodeCaseCode, 4, x => x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier1, 5, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 6, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 7, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 8, x => x.MinLength(1).MaxLength(48));
            Value(x => x.WarehouseLotNumber, 9, x => x.MinLength(1).MaxLength(12));
            Value(x => x.Weight1, 10, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier1, 11, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode1, 12, x => x.FixedLength(1));
            Value(x => x.Weight2, 13, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier2, 14, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode2, 15, x => x.FixedLength(1));
            Value(x => x.InventoryTransactionTypeCode, 16, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ProductOrServiceIdQualifier3, 17, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 18, x => x.MinLength(1).MaxLength(48));
        }
    }
}