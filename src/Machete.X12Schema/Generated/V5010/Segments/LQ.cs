namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface LQ : X12Segment
    {
        Value<string> Qualifier { get; }

        Value<string> RemarkCode { get; }
    }
}