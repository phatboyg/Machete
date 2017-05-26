namespace Machete.HL7.Tests.Segments
{
    using System;
    using Values.Converters;


    public interface MSG :
        HL7Component
    {
        Value<string> MessageCode { get; }
        Value<string> TriggerEvent { get; }
        Value<string> MessageStructure { get; }
    }


    public class MSGComponentMap :
        HL7ComponentMap<MSG, HL7Component>
    {
        public MSGComponentMap()
        {
            Value(x => x.MessageCode, 0, x => x.Required = true);
            Value(x => x.TriggerEvent, 1, x => x.Required = true);
            Value(x => x.MessageStructure, 2);
        }
    }


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


    public class MSHSegmentMap :
        HL7SegmentMap<MSHSegment, HL7Entity>
    {
        public MSHSegmentMap()
        {
            Id = "MSH";

            Value(x => x.Fields, 2);

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
                x.Converter = HL7ValueConverters.VariableLongDateTime;
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


    public interface DateTimeSegment :
        HL7Segment
    {
        Value<DateTime> TestDateTime { get; }
        Value<DateTimeOffset> TestDateTimeOffset { get; }
    }


    public class DateTimeSegmentMap :
        HL7SegmentMap<DateTimeSegment, HL7Segment>
    {
        public DateTimeSegmentMap()
        {
            Id = "ZHX";

            Value(x => x.TestDateTime, 1, x =>
            {
                x.Converter = new DateTimeValueConverter("yyyMMddhhmmss");
                x.MaxLength = 26;
            });
            Value(x => x.TestDateTimeOffset, 2, x => x.LongDateTime().MaxLength(26));
        }
    }


    public interface MessageLayout :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        Layout<OptionalMessageLayout> Optional { get; }
    }


    public interface OptionalMessageLayout :
        HL7Layout
    {
        Segment<EVNSegment> EVN { get; }
    }


    public class MessageLayoutMap :
        HL7LayoutMap<MessageLayout, HL7Entity>
    {
        public MessageLayoutMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Layout(x => x.Optional, 1);
        }
    }


    public class OptionalMessageLayoutMap :
        HL7LayoutMap<OptionalMessageLayout, HL7Entity>
    {
        public OptionalMessageLayoutMap()
        {
            Segment(x => x.EVN, 0);
        }
    }


    public interface EVNSegment :
        HL7Segment
    {
        Value<string> EventTypeCode { get; }
        Value<DateTimeOffset> RecordedDateTime { get; }
        Value<DateTimeOffset> DateTimeOfPlannedEvent { get; }

        Value<string> EventReasonCode { get; }

        //ValueList<XCN> OperatorId { get; }
        Value<DateTimeOffset> EventOccurred { get; }

        //Value<HD> EventFacility { get; }
    }


    public class EVNSegmentMap :
        HL7SegmentMap<EVNSegment, HL7Segment>
    {
        public EVNSegmentMap()
        {
            Id = "EVN";

            Name = "Event Type";

            Value(x => x.EventTypeCode, 1, x => x.MaxLength = 3);
            Value(x => x.RecordedDateTime, 2, x => x.LongDateTime().Required());
            Value(x => x.DateTimeOfPlannedEvent, 3);
            Value(x => x.EventReasonCode, 4, x =>
            {
                x.MaxLength = 3;
                x.Required();
            });
//            Value(x => x.OperatorId, 5).MaxLength(250);
            Value(x => x.EventOccurred, 6, x => x.LongDateTime());
            //          Value(x => x.EventFacility, 7).MaxLength(241);
        }
    }
}