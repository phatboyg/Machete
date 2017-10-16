namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface LE : X12Segment
    {
        Value<string> LoopIdentifierCode { get; }
    }
}