namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SDP :
        X12Segment
    {
        Value<string> ShipDeliveryOrCalendarPatternCode1 { get; }
        
        Value<string> ShipOrDeliveryPatternTimeCode1 { get; }
        
        Value<string> ShipDeliveryOrCalendarPatternCode2 { get; }
        
        Value<string> ShipOrDeliveryPatternTimeCode2 { get; }
        
        Value<string> ShipDeliveryOrCalendarPatternCode3 { get; }
        
        Value<string> ShipOrDeliveryPatternTimeCode3 { get; }
        
        Value<string> ShipDeliveryOrCalendarPatternCode4 { get; }
        
        Value<string> ShipOrDeliveryPatternTimeCode4 { get; }
    }
}