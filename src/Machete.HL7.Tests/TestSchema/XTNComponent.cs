namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface XTNComponent :
        HL7Component
    {
        Value<DateTimeOffset> TelephoneNumber { get; }
        Value<string> TelecommunicationUseCode { get; }
        Value<string> TelecommunicationEquipmentType { get; }
        Value<string> CommunicationAddress { get; }
        Value<decimal> CountryCode { get; }
        Value<decimal> AreaCityCode { get; }
        Value<decimal> LocalNumber { get; }
        Value<decimal> Extension { get; }
        Value<string> AnyText { get; }
        Value<string> ExtensionPrefix { get; }
        Value<string> SpeedDialCode { get; }
        Value<string> UnformattedTelephoneNumber { get; }
        Value<DateTimeOffset> EffectiveStartDate { get; }
        Value<DateTimeOffset> ExpirationDate { get; }
        Value<CWEComponent> ExpirationReason { get; }
        Value<CWEComponent> ProtectionCode { get; }
        Value<EIComponent> SharedTelecommunicationIdentifier { get; }
        Value<decimal> PreferenceOrder { get; }
    }
}