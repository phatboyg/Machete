namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class SHDMap :
        X12SegmentMap<SHD, X12Entity>
    {
        public SHDMap()
        {
            Id = "SHD";
            Name = "Shipment Detail";
            
            Value(x => x.NumberOfUnitsShipped, 1, x => x.MinLength(1).MaxLength(10));
            Value(x => x.QuantityReceived, 2, x => x.MinLength(1).MaxLength(7));
            Value(x => x.UnitOrBasisForMeasurementCode1, 3, x => x.FixedLength(2));
            Value(x => x.Weight, 4, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode2, 5, x => x.FixedLength(2));
            Value(x => x.Volume, 6, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode3, 7, x => x.FixedLength(2));
            Value(x => x.OrderSizingFactor, 8, x => x.MinLength(1).MaxLength(10));
            Value(x => x.PriceBracketIdentifier, 9, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TransportationMethodOrTypeCode, 10, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StandardCarrierAlphaCode, 11, x => x.MinLength(2).MaxLength(4));
            Value(x => x.ShipmentOrOrderStatusCode, 12, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentificationQualifier, 13, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 14, x => x.MinLength(1).MaxLength(30));
        }
    }
}