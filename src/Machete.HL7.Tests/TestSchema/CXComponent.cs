namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface CXComponent :
        HL7Component
    {
        Value<string> IdNumber { get; }
        Value<string> IdentifierCheckDigit { get; }
        Value<string> CheckDigitScheme { get; }
        Value<HDComponent> AssigningAuthority { get; }
        Value<string> IdentifierTypeCode { get; }
        Value<HDComponent> AssigningFacility { get; }
        Value<DateTimeOffset> EffectiveDate { get; }
        Value<DateTimeOffset> ExpirationDate { get; }
        Value<CWEComponent> AssigningJurisdiction { get; }
        Value<CWEComponent> AssigningAgencyOrDepartment { get; }
    }
}