namespace Machete.HL7.Tests.Segments
{
    public interface EIComponent :
        HL7Component
    {
        Value<string> EntityIdentifier { get; }
        Value<string> NamespaceId { get; }
        Value<string> UniversalId { get; }
        Value<string> UniversalIdType { get; }
    }
}