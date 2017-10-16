namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface PS1 : X12Segment
    {
        Value<string> ProviderIdentifier { get; }

        Value<decimal> ChargeAmount { get; }
    }
}