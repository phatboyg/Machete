namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface XADComponent :
        HL7Component
    {
        Value<SADComponent> StreetAddress { get; }
        Value<string> OtherDesignation { get; }
        Value<string> City { get; }
        Value<string> StateOrProvince { get; }
        Value<string> ZipOrPostalCode { get; }
        Value<string> Country { get; }
        Value<string> AddressType { get; }
        Value<string> OtherGeographicDesignation { get; }
        Value<string> CountyParishCode { get; }
        Value<string> CensuTract { get; }
        Value<string> AddressRepresentationCode { get; }
        Value<DRComponent> AddressValidityRange { get; }
        Value<DateTimeOffset> EffectiveDate { get; }
        Value<DateTimeOffset> ExpirationDate { get; }
        Value<CWEComponent> ExpirationReason { get; }
        Value<string> TemporaryIndicator { get; }
        Value<string> BadAddressIndicator { get; }
        Value<string> AddressUsage { get; }
        Value<string> Addressee { get; }
        Value<string> Comment { get; }
        Value<decimal> PreferenceOrder { get; }
        Value<CWEComponent> ProtectionCode { get; }
        Value<EIComponent> AddressIdentifier { get; }
    }
}