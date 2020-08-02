namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AT9 :
        X12Segment
    {
        Value<int> EquipmentLength { get; }
        
        Value<decimal> Height { get; }
        
        Value<decimal> Width { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<decimal> Volume { get; }
    }
}