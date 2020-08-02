namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W27Map :
        X12SegmentMap<W27, X12Entity>
    {
        public W27Map()
        {
            Id = "W27";
            Name = "Carrier Details (Warehouse)";
            
            Value(x => x.TransportationMethodOrTypeCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.StandardCarrierAlphaCode, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.Routing, 3, x => x.MinLength(1).MaxLength(35));
            Value(x => x.ShipmentMethodOfPayment, 4, x => x.FixedLength(2));
            Value(x => x.EquipmentDescriptionCode, 5, x => x.FixedLength(2));
            Value(x => x.EquipmentInitial, 6, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.ShipmentOrOrderStatusCode, 8, x => x.FixedLength(2));
            Value(x => x.SpecialHandlingCode, 9, x => x.MinLength(2).MaxLength(3));
            Value(x => x.CarrierOrRouteChangeReasonCode, 10, x => x.FixedLength(2));
        }
    }
}