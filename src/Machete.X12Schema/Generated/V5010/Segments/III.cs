namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface III : X12Segment
    {
        Value<string> CodeListQualifierCode { get; }

        Value<string> IndustryCode { get; }
    }
}