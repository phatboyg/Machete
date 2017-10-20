namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface MOA : X12Segment
    {
        Value<decimal> ReimbursementRate { get; }

        Value<decimal> HcpcsPayable { get; }

        Value<string> RemarkCode1 { get; }

        Value<string> RemarkCode2 { get; }

        Value<string> RemarkCode3 { get; }

        Value<string> RemarkCode4 { get; }

        Value<string> RemarkCode5 { get; }

        Value<decimal> EsrdPayment { get; }

        Value<decimal> NonpayableProfessionalComponent { get; }
    }
}