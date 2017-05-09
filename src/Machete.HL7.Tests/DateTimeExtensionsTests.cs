namespace Machete.HL7.Tests
{
    using System;
    using HL7.Tests.Segments;
    using NUnit.Framework;


    [TestFixture]
    public class DateTimeExtensionsTests
    {
        private IParser<HL7Entity> _parser;

        [OneTimeSetUp]
        public void Setup()
        {
            var schema = Schema.Factory.CreateHL7(x =>
            {
                x.Add(new MSGComponentMap());
                x.Add(new FakeMSHSegmentMap());
                x.Add(new EVNSegmentMap());
            });

            _parser = Parser.Factory.CreateHL7(schema);
        }

        [Test]
        public void Verify_can_convert_to_different_time_zone()
        {
            //const string message1 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            Console.WriteLine(result.Value.CreationDateTime.HasValue);

            DateTimeOffset dateTime = result.Value.CreationDateTime.Value;
            TimeSpan timeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time").GetUtcOffset(dateTime);
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime, timeZone);

            //TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            //Assert.AreEqual(expected, result.Value.CreationDateTime.Value.ConvertTo(destinationTimeZone));

        }



    }



    interface FakeMSHSegment :
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


    class FakeMSHSegmentMap :
        HL7SegmentMap<FakeMSHSegment, HL7Segment>
    {
        public FakeMSHSegmentMap()
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
                x.Converter = HL7ValueConverters.VariableLongDate;
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