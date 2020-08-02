namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface R2 :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> RoutingSequenceCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StandardPointLocationCode { get; }
        
        Value<string> IntermodalServiceCode { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> IntermediateSwitchCarrier1 { get; }
        
        Value<string> IntermediateSwitchCarrier2 { get; }
        
        Value<string> InvoiceNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> FreeformDescription { get; }
        
        Value<string> TypeOfServiceCode { get; }
        
        Value<string> RouteDescription { get; }
    }
}