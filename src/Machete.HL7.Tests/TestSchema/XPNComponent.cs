namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface XPNComponent :
        HL7Component
    {
        Value<FNComponent> FamilyName { get; }
        Value<string> GivenName { get; }
        Value<string> SecondAndFurtherGivenNamesOrInitialsreof { get; }
        Value<string> Suffix { get; }
        Value<string> Prefix { get; }
        Value<string> Degree { get; }
        Value<string> NameTypeCode { get; }
        Value<string> NameRepresentationCode { get; }
        Value<CWEComponent> NameContext { get; }
        Value<DRComponent> NameValidityRange { get; }
        Value<string> NameAssemblyOrder { get; }
        Value<DateTimeOffset> EffectiveDate { get; }
        Value<DateTimeOffset> ExpirationDate { get; }
        Value<string> ProfessionalSuffix { get; }
    }
}