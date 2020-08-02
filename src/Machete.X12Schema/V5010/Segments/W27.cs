namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W27 :
        X12Segment
    {
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> Routing { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> EquipmentDescriptionCode { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<string> ShipmentOrOrderStatusCode { get; }
        
        Value<string> SpecialHandlingCode { get; }
        
        Value<string> CarrierOrRouteChangeReasonCode { get; }
    }
}