namespace Machete.HL7.Tests
{
    using System;
    using Segments;
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

        [Test, Explicit("This only runs on Windows because of usage of TimeZoneInfo.FindSystemTimeZoneById")]
        public void Verify_can_convert_datetime_to_different_time_zone()
        {
            DateTime dt = new DateTime(2017, 5, 10, 15, 10, 35);
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset expected = new DateTimeOffset(dt, offset);
            TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            DateTimeOffset actual = dt.ConvertTo(destinationTimeZone);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Verify_can_convert_datetimeoffset_to_different_time_zone_given_timespan()
        {
            DateTime dt = new DateTime(2017, 5, 10, 15, 10, 35);
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset expected = new DateTimeOffset(dt, offset);

            DateTimeOffset actual = dt.ConvertTo(offset);

            Assert.AreEqual(expected, actual);
        }

        [Test, Explicit("This only runs on Windows because of usage of TimeZoneInfo.FindSystemTimeZoneById")]
        public void Verify_can_convert_datetimeoffset_to_different_time_zone()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            Console.WriteLine(result.Value.CreationDateTime.HasValue);

            DateTimeOffset dateTime = result.Value.CreationDateTime.Value;
            TimeSpan timeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time").GetUtcOffset(dateTime);
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime, timeZone);

            TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            //DateTimeOffset actual = result.Value.CreationDateTime.Value.ConvertTo(destinationTimeZone).ToUtc();
            var actual = result.Value.CreationDateTime.Value.ConvertTo(destinationTimeZone);
            //Assert.AreEqual(expected, actual);
        }
}