namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface XCNComponent :
        HL7Component
    {
        Value<string> IdNumber { get; }
        Value<FNComponent> FamilyName { get; }
        Value<string> GivenName { get; }
        Value<string> SecondAndFurtherGivenNamesOrInitialsreof { get; }
        Value<string> Suffix { get; }
        Value<string> Prefix { get; }
        Value<string> Degree { get; }
        Value<string> SourceTable { get; }
        Value<HDComponent> AssigningAuthority { get; }
        Value<string> NameTypeCode { get; }
        Value<string> IdentifierCheckDigit { get; }
        Value<string> CheckDigitScheme { get; }
        Value<string> IdentifierTypeCode { get; }
        Value<HDComponent> AssigningFacility { get; }
        Value<string> NameRepresentationCode { get; }
        Value<CWEComponent> NameContext { get; }
        Value<DRComponent> NameValidityRange { get; }
        Value<string> NameAssemblyOrder { get; }
        Value<DateTimeOffset> EffectiveDate { get; }
        Value<DateTimeOffset> ExpirationDate { get; }
        Value<string> ProfessionalSuffix { get; }
        Value<CWEComponent> AssigningJurisdiction { get; }
        Value<CWEComponent> AssigningAgencyOrDepartment { get; }
    }
}