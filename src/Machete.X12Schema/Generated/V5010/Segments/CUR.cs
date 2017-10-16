namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CUR : X12Segment
    {
        Value<string> EntityIdentifierCode { get; }

        Value<string> CurrencyCode { get; }
    }
}