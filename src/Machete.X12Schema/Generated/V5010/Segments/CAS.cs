namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CAS : X12Segment
    {
        Value<string> GroupCode { get; }

        Value<string> ReasonCode1 { get; }

        Value<decimal> Amount1 { get; }

        Value<decimal> Quantity1 { get; }

        Value<string> ReasonCode2 { get; }

        Value<decimal> Amount2 { get; }

        Value<decimal> Quantity2 { get; }

        Value<string> ReasonCode3 { get; }

        Value<decimal> Amount3 { get; }

        Value<decimal> Quantity3 { get; }

        Value<string> ReasonCode4 { get; }

        Value<decimal> Amount4 { get; }

        Value<decimal> Quantity4 { get; }

        Value<string> ReasonCode5 { get; }

        Value<decimal> Amount5 { get; }

        Value<decimal> Quantity5 { get; }

        Value<string> ReasonCode6 { get; }

        Value<decimal> Amount6 { get; }

        Value<decimal> Quantity6 { get; }
    }
}