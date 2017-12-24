namespace Machete.HL7.Tests.TestSchema
{
    public interface HDComponent :
        HL7Component
    {
        Value<string> NamespaceId { get; }
        Value<string> UniversalId { get; }
        Value<string> UniversalIdType { get; }
    }
}