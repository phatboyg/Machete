namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W01Map :
        X12SegmentMap<W01, X12Entity>
    {
        public W01Map()
        {
            Id = "W01";
            Name = "Line Item Detail - Warehouse";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOrBasisOfMeasurementCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.UniversalProductCodeCaseCode, 3, x => x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier1, 4, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 5, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 6, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 7, x => x.MinLength(1).MaxLength(48));
            Value(x => x.FreightClassCode, 8, x => x.MinLength(2).MaxLength(5));
            Value(x => x.RateClassCode, 9, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CommodityCodeQualifier, 10, x => x.FixedLength(1));
            Value(x => x.CommodityCode, 11, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PalletBlockAndTiers, 12, x => x.FixedLength(6));
            Value(x => x.WarehouseLotNumber, 13, x => x.MinLength(1).MaxLength(12));
            Value(x => x.ProductOrServiceConditionCode, 14, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceIdQualifier3, 15, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 16, x => x.MinLength(1).MaxLength(48));
        }
    }
}