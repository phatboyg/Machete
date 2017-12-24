namespace Machete.HL7.Tests.TestSchema
{
    public class MSHSegmentMap :
        HL7SegmentMap<MSHSegment, HL7Entity>
    {
        public MSHSegmentMap()
        {
            Id = "MSH";

            Value(x => x.EncodingCharacters, 1, x =>
            {
                x.MaxLength = 4;
                x.Required = true;
            });
            Value(x => x.SendingApplication, 2, x =>
            {
                x.MaxLength = 227;
                x.Required = true;
            });
            Value(x => x.SendingFacility, 3, x => { x.MaxLength = 227; });
            Value(x => x.ReceivingApplication, 4, x => { x.MaxLength = 227; });
            Value(x => x.ReceivingFacility, 5, x => { x.MaxLength = 227; });
            Value(x => x.CreationDateTime, 6, x =>
            {
                x.LongDateTimeOffset();
                x.MaxLength = 26;
            });
            Value(x => x.Security, 7, x => { x.MaxLength = 40; });
            Entity(x => x.MessageType, 8, x =>
            {
                x.MaxLength = 15;
                x.Required = true;
            });
            Value(x => x.MessageControlId, 9, x =>
            {
                x.MaxLength = 199;
                x.Required = true;
            });
            Value(x => x.ProcessingId, 10, x =>
            {
                x.MaxLength = 3;
                x.Required = true;
            });
            Value(x => x.VersionId, 11, x =>
            {
                x.MaxLength = 60;
                x.Required = true;
            });
            Value(x => x.SequenceNumber, 12, x => { x.MaxLength = 15; });
            Value(x => x.ContinuationPointer, 13, x => { x.MaxLength = 18; });
            Value(x => x.AcceptAcknowledgmentType, 14, x => { x.MaxLength = 2; });
            Value(x => x.ApplicationAcknowledgmentType, 15, x => { x.MaxLength = 2; });
            Value(x => x.CountryCode, 16, x => { x.MaxLength = 3; });
            Value(x => x.CharacterSet, 17, x => { x.MaxLength = 16; });
            Value(x => x.PrincipalLanguageOfMessage, 18, x => { x.MaxLength = 25; });
            Value(x => x.AlternateCharacterSetHandlingScheme, 19, x => { x.MaxLength = 20; });
            Value(x => x.MessageProfileId, 20, x => { x.MaxLength = 42; });
            Value(x => x.SendingResponsibleOrganization, 21, x => { x.MaxLength = 56; });
            Value(x => x.ReceivingResponsibleOrganization, 22, x => { x.MaxLength = 56; });
            Value(x => x.SendingNetworkAddress, 23, x => { x.MaxLength = 22; });
            Value(x => x.ReceivingNetworkAddress, 24, x => { x.MaxLength = 22; });
        }
    }
}