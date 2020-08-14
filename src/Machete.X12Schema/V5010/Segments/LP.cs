namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LP :
        X12Segment
    {
        Value<string> EquipmentType { get; }
        
        Value<string> ShipmentIdentificationNumber1 { get; }
        
        Value<string> ShipmentIdentificationNumber2 { get; }
        
        Value<string> VentInstructionCode { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<int> Number1 { get; }
        
        Value<int> Number2 { get; }
    }
}