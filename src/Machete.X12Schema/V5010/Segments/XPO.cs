namespace Machete.X12Schema.V5010
{
    using X12;


    public interface XPO :
        X12Segment
    {
        Value<string> PurchaseOrderNumber1 { get; }
        
        Value<string> PurchaseOrderNumber2 { get; }
        
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode { get; }
    }
}