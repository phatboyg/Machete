namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface LIN : X12Segment
    {
        Value<string> Qualifier { get; }

        // TODO qualifier 2
        Value<string> NationalDrugCode { get; }
    }
}