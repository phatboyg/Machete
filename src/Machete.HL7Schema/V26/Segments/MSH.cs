// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// MSH (Segment) - Message Header
    /// </summary>
    public interface MSH :
        HL7V26Segment
    {
        /// <summary>
        /// MSH-2: Encoding Characters
        /// </summary>
        Value<string> EncodingCharacters { get; }

        /// <summary>
        /// MSH-3: Sending Application
        /// </summary>
        Value<HD> SendingApplication { get; }

        /// <summary>
        /// MSH-4: Sending Facility
        /// </summary>
        Value<HD> SendingFacility { get; }

        /// <summary>
        /// MSH-5: Receiving Application
        /// </summary>
        Value<HD> ReceivingApplication { get; }

        /// <summary>
        /// MSH-6: Receiving Facility
        /// </summary>
        Value<HD> ReceivingFacility { get; }

        /// <summary>
        /// MSH-7: Date/Time of Message
        /// </summary>
        Value<DateTimeOffset> DateTimeOfMessage { get; }

        /// <summary>
        /// MSH-8: Security
        /// </summary>
        Value<string> Security { get; }

        /// <summary>
        /// MSH-9: Message Type
        /// </summary>
        Value<MSG> MessageType { get; }

        /// <summary>
        /// MSH-10: Message Control ID
        /// </summary>
        Value<string> MessageControlId { get; }

        /// <summary>
        /// MSH-11: Processing ID
        /// </summary>
        Value<PT> ProcessingId { get; }

        /// <summary>
        /// MSH-12: Version ID
        /// </summary>
        Value<VID> VersionId { get; }

        /// <summary>
        /// MSH-13: Sequence Number
        /// </summary>
        Value<decimal> SequenceNumber { get; }

        /// <summary>
        /// MSH-14: Continuation Pointer
        /// </summary>
        Value<string> ContinuationPointer { get; }

        /// <summary>
        /// MSH-15: Accept Acknowledgment Type
        /// </summary>
        Value<string> AcceptAcknowledgmentType { get; }

        /// <summary>
        /// MSH-16: Application Acknowledgment Type
        /// </summary>
        Value<string> ApplicationAcknowledgmentType { get; }

        /// <summary>
        /// MSH-17: Country Code
        /// </summary>
        Value<string> CountryCode { get; }

        /// <summary>
        /// MSH-18: Character Set
        /// </summary>
        ValueList<string> CharacterSet { get; }

        /// <summary>
        /// MSH-19: Principal Language Of Message
        /// </summary>
        Value<CWE> PrincipalLanguageOfMessage { get; }

        /// <summary>
        /// MSH-20: Alternate Character Set Handling Scheme
        /// </summary>
        Value<string> AlternateCharacterSetHandlingScheme { get; }

        /// <summary>
        /// MSH-21: Message Profile Identifier
        /// </summary>
        ValueList<EI> MessageProfileIdentifier { get; }

        /// <summary>
        /// MSH-22: Sending Responsible Organization
        /// </summary>
        Value<XON> SendingResponsibleOrganization { get; }

        /// <summary>
        /// MSH-23: Receiving Responsible Organization
        /// </summary>
        Value<XON> ReceivingResponsibleOrganization { get; }

        /// <summary>
        /// MSH-24: Sending Network Address
        /// </summary>
        Value<HD> SendingNetworkAddress { get; }

        /// <summary>
        /// MSH-25: Receiving Network Address
        /// </summary>
        Value<HD> ReceivingNetworkAddress { get; }
    }
}