namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Y7 :
        X12Segment
    {
        Value<string> BookingNumber { get; }
    }
}