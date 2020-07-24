namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ADX :
        X12Segment
    {
        Value<decimal> MonetaryAmount { get; }

        Value<string> AdjustmentReasonCode { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
    }
}