namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ISSMap :
        X12SegmentMap<ISS, X12Entity>
    {
        public ISSMap()
        {
            Id = "ISS";
            Name = "Invoice Shipment Summary";
            
            Value(x => x.NumberOfUnitsShipped, 1, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode1, 2, x => x.FixedLength(2));
            Value(x => x.Weight1, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode2, 4, x => x.FixedLength(2));
            Value(x => x.Volume, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode3, 6, x => x.FixedLength(2));
            Value(x => x.Quantity, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Weight2, 8, x => x.MinLength(1).MaxLength(10));
        }
    }
}