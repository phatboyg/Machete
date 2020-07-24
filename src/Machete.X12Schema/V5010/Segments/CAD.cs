namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CAD :
        X12Segment
    {
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> Routing { get; }
        
        Value<string> ShipmentOrOrderStatusCode { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> ServiceLevelCode { get; }
    }
}