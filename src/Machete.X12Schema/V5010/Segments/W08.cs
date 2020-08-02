namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W08 :
        X12Segment
    {
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> Routing { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<string> SealNumber1 { get; }
        
        Value<string> SealNumber2 { get; }
        
        Value<string> SealStatusCode { get; }

        Value<string> UnitLoadOptionCode { get; }
    }
}