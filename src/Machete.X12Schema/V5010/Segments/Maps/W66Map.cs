namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W66Map :
        X12SegmentMap<W66, X12Entity>
    {
        public W66Map()
        {
            Id = "W66";
            Name = "Warehouse Carrier Information";
            
            Value(x => x.ShipmentMethodOfPayment, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.TransportationMethodOrTypeCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.PalletExchangeCode, 3, x => x.FixedLength(1));
            Value(x => x.UnitLoadOptionCode, 4, x => x.FixedLength(2));
            Value(x => x.Routing, 5, x => x.MinLength(1).MaxLength(35));
            Value(x => x.FreeOnBoardPointCode, 6, x => x.FixedLength(2));
            Value(x => x.FreeOnBoardPoint, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CashOnDeliveryMethodOfPaymentCode, 8, x => x.FixedLength(2));
            Value(x => x.Amount, 9, x => x.MinLength(1).MaxLength(15));
            Value(x => x.StandardCarrierAlphaCode, 10, x => x.MinLength(2).MaxLength(4));
        }
    }
}