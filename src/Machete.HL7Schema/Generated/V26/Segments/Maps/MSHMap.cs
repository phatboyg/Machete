// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MSH (SegmentMap) - Message Header
    /// </summary>
    public class MSHMap :
        HL7V26SegmentMap<MSH>
    {
        public MSHMap()
        {
            Id = "MSH";

            Name = "Message Header";

            Value(x => x.EncodingCharacters, 1, x => x.IsRequired());
            Entity(x => x.SendingApplication, 2);
            Entity(x => x.SendingFacility, 3);
            Entity(x => x.ReceivingApplication, 4);
            Entity(x => x.ReceivingFacility, 5);
            Value(x => x.DateTimeOfMessage, 6, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.Security, 7);
            Entity(x => x.MessageType, 8, x => x.IsRequired());
            Value(x => x.MessageControlId, 9, x => x.IsRequired());
            Entity(x => x.ProcessingId, 10, x => x.IsRequired());
            Entity(x => x.VersionId, 11, x => x.IsRequired());
            Value(x => x.SequenceNumber, 12);
            Value(x => x.ContinuationPointer, 13);
            Value(x => x.AcceptAcknowledgmentType, 14);
            Value(x => x.ApplicationAcknowledgmentType, 15);
            Value(x => x.CountryCode, 16);
            Value(x => x.CharacterSet, 17);
            Entity(x => x.PrincipalLanguageOfMessage, 18);
            Value(x => x.AlternateCharacterSetHandlingScheme, 19);
            Entity(x => x.MessageProfileIdentifier, 20);
            Entity(x => x.SendingResponsibleOrganization, 21);
            Entity(x => x.ReceivingResponsibleOrganization, 22);
            Entity(x => x.SendingNetworkAddress, 23);
            Entity(x => x.ReceivingNetworkAddress, 24);
        }
    }
}