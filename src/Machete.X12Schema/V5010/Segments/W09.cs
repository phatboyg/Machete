namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W09 :
        X12Segment
    {
        Value<string> EquipmentDescriptionCode { get; }
        
        Value<string> Temperature1 { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode1 { get; }
        
        Value<string> Temperature2 { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode2 { get; }
        
        Value<string> FreeformMessage { get; }
        
        Value<string> VentSettingCode { get; }
        
        Value<int> PercentIntegerFormat { get; }
        
        Value<int> Quantity { get; }
    }
}