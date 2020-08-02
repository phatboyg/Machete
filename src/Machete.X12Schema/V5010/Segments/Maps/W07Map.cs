namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W07Map :
        X12SegmentMap<W07, X12Entity>
    {
        public W07Map()
        {
            Id = "W07";
            Name = "Item Detail For Stock Receipt";
            
            Value(x => x.QuantityReceived, 1, x => x.MinLength(1).MaxLength(7));
            Value(x => x.UnitOrBasisOfMeasurementCode, 2, x => x.FixedLength(2));
            Value(x => x.UniversalProductCodeCaseCode, 3, x => x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier1, 4, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 5, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 6, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 7, x => x.MinLength(1).MaxLength(48));
            Value(x => x.WarehouseLotNumber, 8, x => x.MinLength(1).MaxLength(12));
            Value(x => x.WarehouseDetailAdjustmentIdentifier, 9, x => x.FixedLength(1));
            Value(x => x.ProductOrServiceIdQualifier3, 10, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 11, x => x.MinLength(1).MaxLength(48));
        }
    }
}