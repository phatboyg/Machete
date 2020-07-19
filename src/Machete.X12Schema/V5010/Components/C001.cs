namespace Machete.X12Schema.V5010.Components
{
    using X12;


    public interface C001 :
        X12Component
    {
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Exponent1 { get; }
        
        Value<decimal> Multiplier1 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Exponent2 { get; }
        
        Value<decimal> Multiplier2 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> Exponent3 { get; }
        
        Value<decimal> Multiplier3 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode4 { get; }
        
        Value<decimal> Exponent4 { get; }
        
        Value<decimal> Multiplier4 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode5 { get; }
        
        Value<decimal> Exponent5 { get; }
        
        Value<decimal> Multiplier5 { get; }
    }
}