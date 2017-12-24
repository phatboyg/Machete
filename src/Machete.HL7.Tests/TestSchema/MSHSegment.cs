namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface MSHSegment :
        HL7Segment
    {
        Value<string> EncodingCharacters { get; }
        Value<string> SendingApplication { get; }
        Value<string> SendingFacility { get; }
        Value<string> ReceivingApplication { get; }
        Value<string> ReceivingFacility { get; }
        Value<DateTimeOffset> CreationDateTime { get; }
        Value<string> Security { get; }
        Value<MSG> MessageType { get; }
        Value<string> MessageControlId { get; }
        Value<string> ProcessingId { get; }
        Value<string> VersionId { get; }
        Value<decimal> SequenceNumber { get; }
        Value<string> ContinuationPointer { get; }
        Value<string> AcceptAcknowledgmentType { get; }
        Value<string> ApplicationAcknowledgmentType { get; }
        Value<string> CountryCode { get; }
        Value<string> CharacterSet { get; }
        Value<string> PrincipalLanguageOfMessage { get; }
        Value<string> AlternateCharacterSetHandlingScheme { get; }
        Value<string> MessageProfileId { get; }
        Value<string> SendingResponsibleOrganization { get; }
        Value<string> ReceivingResponsibleOrganization { get; }
        Value<string> SendingNetworkAddress { get; }
        Value<string> ReceivingNetworkAddress { get; }
    }
}