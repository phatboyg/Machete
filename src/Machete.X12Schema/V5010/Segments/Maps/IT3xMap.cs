namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class IT3xMap :
        X12SegmentMap<IT3x, X12Entity>
    {
        public IT3xMap()
        {
            Id = "IT3";
            Name = "Additional Item Data";
            
            Value(x => x.NumberOfUnitsShipped, 1, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode, 2, x => x.FixedLength(2));
            Value(x => x.ShipmentOrOrderStatusCode, 3, x => x.FixedLength(2));
            Value(x => x.QuantityDifference, 4, x => x.MinLength(1).MaxLength(9));
            Value(x => x.ChangeReasonCode, 5, x => x.FixedLength(2));
        }
    }
}