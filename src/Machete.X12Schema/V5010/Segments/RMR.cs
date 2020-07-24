namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RMR :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<decimal> PaymentActionCode { get; }
        
        Value<decimal> MonetaryAmount1 { get; }
        
        Value<decimal> MonetaryAmount2 { get; }
        
        Value<decimal> MonetaryAmount3 { get; }

        Value<string> AdjustmentReasonCode { get; }
        
        Value<decimal> MonetaryAmount4 { get; }
    }
}