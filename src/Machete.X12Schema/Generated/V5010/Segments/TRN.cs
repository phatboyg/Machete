namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface TRN :
        X12Segment
    {
        Value<string> TraceTypeCode { get; }

        Value<string> ReferenceIdentification1 { get; }

        Value<string> OriginatingCompanyId { get; }

        Value<string> ReferenceIdentification2 { get; }
    }
}