namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface LQ :
        X12Segment
    {
        Value<string> QualifierCode { get; }

        Value<string> IndustryCode { get; }
    }
}