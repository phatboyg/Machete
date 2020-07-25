namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TD5 :
        X12Segment
    {
        Value<string> RoutingSequenceCode { get; }
        
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> Routing { get; }
        
        Value<string> ShipmentOrOrderStatusCode { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> TransitDirectionCode { get; }
        
        Value<string> TransitTimeDirectionQualifier { get; }
        
        Value<string> TransitTime { get; }
        
        Value<string> ServiceLevelCode1 { get; }
        
        Value<string> ServiceLevelCode2 { get; }
        
        Value<string> ServiceLevelCode3 { get; }
        
        Value<string> CountryCode { get; }
    }
}