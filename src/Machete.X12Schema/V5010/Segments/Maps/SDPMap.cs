namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SDPMap :
        X12SegmentMap<SDP, X12Entity>
    {
        public SDPMap()
        {
            Id = "SDP";
            Name = "Ship/Delivery Pattern";
            
            Value(x => x.ShipDeliveryOrCalendarPatternCode1, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ShipOrDeliveryPatternTimeCode1, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.ShipDeliveryOrCalendarPatternCode2, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ShipOrDeliveryPatternTimeCode2, 4, x => x.FixedLength(1));
            Value(x => x.ShipDeliveryOrCalendarPatternCode3, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ShipOrDeliveryPatternTimeCode3, 6, x => x.FixedLength(1));
            Value(x => x.ShipDeliveryOrCalendarPatternCode4, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ShipOrDeliveryPatternTimeCode4, 8, x => x.FixedLength(1));
        }
    }
}