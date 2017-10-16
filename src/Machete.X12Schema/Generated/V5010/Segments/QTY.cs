namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface QTY : X12Segment
    {
        Value<string> QuanityQualifier { get; }

        Value<decimal> SupplementalInformationQuantity { get; }
    }
}