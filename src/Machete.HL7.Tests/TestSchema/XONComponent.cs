namespace Machete.HL7.Tests.TestSchema
{
    public interface XONComponent :
        HL7Component
    {
        Value<string> OrganizationName { get; }
        Value<string> OrganizationNameTypeCode { get; }
        Value<decimal> IdNumber { get; }
        Value<decimal> IdentifierCheckDigit { get; }
        Value<string> CheckDigitScheme { get; }
        Value<HDComponent> AssigningAuthority { get; }
        Value<string> IdentifierTypeCode { get; }
        Value<HDComponent> AssigningFacility { get; }
        Value<string> NameRepresentationCode { get; }
        Value<string> OrganizationIdentifier { get; }
    }
}