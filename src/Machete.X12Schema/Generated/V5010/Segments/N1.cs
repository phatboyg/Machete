namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface N1 :
        X12Segment
    {
        Value<string> EntityIdCode { get; }

        Value<string> EntityName { get; }

        Value<string> IdCodeQualifier { get; }

        Value<string> IdCode { get; }
    }
}