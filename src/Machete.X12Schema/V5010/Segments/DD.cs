namespace Machete.X12Schema.V5010
{
    using X12;


    public interface DD :
        X12Segment
    {
        Value<string> IndustryCode1 { get; }
        
        Value<string> CodeListQualifierCode1 { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> IndustryCode2 { get; }
        
        Value<string> CodeListQualifierCode2 { get; }
        
        Value<decimal> Quantity { get; }

        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<string> IndustryCode3 { get; }
        
        Value<string> CodeListQualifierCode3 { get; }
    }
}