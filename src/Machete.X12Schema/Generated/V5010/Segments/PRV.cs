namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface PRV : X12Segment
    {
        Value<string> ProviderCode { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
    }
}