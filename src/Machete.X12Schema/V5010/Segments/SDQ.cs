namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface SDQ :
        X12Segment
    {
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode1 { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<string> IdentificationCode2 { get; }
        
        Value<decimal> Quantity2 { get; }
        
        Value<string> IdentificationCode3 { get; }
        
        Value<decimal> Quantity3 { get; }
        
        Value<string> IdentificationCode4 { get; }
        
        Value<decimal> Quantity4 { get; }
        
        Value<string> IdentificationCode5 { get; }
        
        Value<decimal> Quantity5 { get; }
        
        Value<string> IdentificationCode6 { get; }
        
        Value<decimal> Quantity6 { get; }
        
        Value<string> IdentificationCode7 { get; }
        
        Value<decimal> Quantity7 { get; }
        
        Value<string> IdentificationCode8 { get; }
        
        Value<decimal> Quantity8 { get; }
        
        Value<string> IdentificationCode9 { get; }
        
        Value<decimal> Quantity9 { get; }
        
        Value<string> IdentificationCode10 { get; }
        
        Value<decimal> Quantity10 { get; }
        
        Value<string> LocationIdentifier { get; }
    }
}