namespace Machete.HL7.Tests.ValueConversionTests
{
    using System;
    using System.Drawing.Printing;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class DateTimeExtensionsTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_can_convert_DateTime_to_different_time_zone_given_TimeZoneInfo()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
ZDTO|20170113|201705221530";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zdto in q.Select<DateTimeOffsetSegment>()
                select zdto);

            var result = entityResult.Query(query);

            Value<DateTimeOffset> dt = result.Result.TestDateTimeOffsetWithTime;
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset dateTime = dt.ValueOrDefault();
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime, offset);

            DateTimeOffset actual = dt.AdjustOffset(offset).ValueOrDefault();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_throw_ArgumentNullException_when_DateTimeOffset_is_null_and_offset_is_not()
        {
            Value<DateTimeOffset> dt = null;
            TimeZoneInfo destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");

            Assert.Throws<ArgumentNullException>(() =>
            {
                DateTimeOffset actual = dt.AdjustTimeZone(destinationTimeZone).ValueOrDefault();
            });
        }

        [Test]
        public void Should_throw_ArgumentNullException_when_time_zone_is_null()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
ZDTO|20170113|201705221530";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zdto in q.Select<DateTimeOffsetSegment>()
                select zdto);

            var result = entityResult.Query(query);

            Value<DateTimeOffset> dt = result.Result.TestDateTimeOffsetWithTime;

            Assert.Throws<ArgumentNullException>(() =>
            {
                DateTimeOffset actual = dt.AdjustTimeZone(null).ValueOrDefault();
            });
        }

        [Test]
        public void Should_throw_ArgumentNullException_when_DateTimeOffset_is_null()
        {
            Value<DateTimeOffset> dt = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                DateTimeOffset actual = dt.AdjustTimeZone(null).ValueOrDefault();
            });
        }

#if !NETCORE
        [Test]
        public void Verify_can_convert_datetimeoffset_to_different_time_zone()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);

            DateTimeOffset dt = result.Result.CreationDateTime.Value;
            TimeZoneInfo destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");
            DateTimeOffset expected = TimeZoneInfo.ConvertTime(dt, destinationTimeZone);
            DateTimeOffset actual = result.Result.CreationDateTime.AdjustTimeZone(destinationTimeZone).ValueOrDefault();

            Assert.AreEqual(expected, actual);
        }
#endif
    }
}