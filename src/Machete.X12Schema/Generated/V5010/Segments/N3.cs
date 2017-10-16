namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface N3 : X12Segment
    {
        Value<string> AddressInformation1 { get; }

        Value<string> AddressInformation2 { get; }
    }
}