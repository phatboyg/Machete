namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface MSG : X12Segment
    {
        Value<string> FreeFormMessageText { get; }
    }
}