namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W10 :
        X12Segment
    {
        Value<string> UnitLoadOptionCode { get; }
        
        Value<int> QuantityOfPalletsShipped { get; }
        
        Value<string> PalletExchangeCode { get; }
        
        Value<string> SealNumber1 { get; }
        
        Value<string> SealNumber2 { get; }
        
        Value<string> Temperature1 { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode1 { get; }
        
        Value<string> Temperature2 { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode2 { get; }
    }
}