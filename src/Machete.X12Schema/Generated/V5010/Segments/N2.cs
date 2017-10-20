namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface N2 : X12Segment
    {
        Value<string> Name { get; }
    }
}