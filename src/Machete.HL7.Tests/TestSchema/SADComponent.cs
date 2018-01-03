namespace Machete.HL7.Tests.TestSchema
{
    public interface SADComponent :
        HL7Component
    {
        Value<string> StreetOrMailingAddress { get; }
        Value<string> StreetName { get; }
        Value<string> DwellingNumber { get; }
    }
}