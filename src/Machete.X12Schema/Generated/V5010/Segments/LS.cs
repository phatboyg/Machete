namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface LS : X12Segment
    {
        Value<string> LoopIdentifierCode { get; }
    }
}