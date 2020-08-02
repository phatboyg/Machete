namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G72 :
        X12Segment
    {
        Value<string> AllowanceOrChargeCode { get; }
        
        Value<string> AllowanceOrChargeMethodOfHandlingCode { get; }
        
        Value<string> AllowanceOrChargeNumber { get; }
        
        Value<string> ExceptionNumber { get; }
        
        Value<decimal> AllowanceOrChargeRate { get; }
        
        Value<decimal> AllowanceOrChargeQuantity { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<decimal> AllowanceOrChargeTotalAmount { get; }
        
        Value<decimal> PercentDecimalFormat { get; }
        
        Value<decimal> DollarBasisForPercent { get; }
        
        Value<string> OptionNumber { get; }
    }
}