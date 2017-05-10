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
                x.Add(new MSHSegmentMap());
                x.Add(new EVNSegmentMap());
            });

            _parser = Parser.Factory.CreateHL7(schema);
        }

        [Test]
        public void Verify_can_convert_to_different_time_zone()
        {
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

            TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            //DateTimeOffset actual = result.Value.CreationDateTime.Value.ConvertTo(destinationTimeZone).ToUtc();
            var actual = result.Value.CreationDateTime.Value.ConvertTo(destinationTimeZone);

            //Assert.AreEqual(expected, actual);
        }



    }
}