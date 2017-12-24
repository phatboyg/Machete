namespace Machete.HL7.Tests.ValueConversionTests
{
    using System;
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
ZHX|20170113|201705221530";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zhx in q.Select<DateTimeSegment>()
                select new
                {
                    MSH = msh,
                    ZHX = zhx
                });

            var result = entityResult.Query(query);

            Value<DateTimeOffset> dt = result.Result.ZHX.TestDateTimeOffsetWithTime;
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset dateTime = dt.ValueOrDefault();
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime, offset);

            DateTimeOffset actual = dt.AdjustOffset(offset).ValueOrDefault();

            Assert.AreEqual(expected, actual);
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
            var destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");
            DateTimeOffset expected = TimeZoneInfo.ConvertTime(dt, destinationTimeZone);
            DateTimeOffset actual = result.Result.CreationDateTime.AdjustTimeZone(destinationTimeZone).ValueOrDefault();

            Assert.AreEqual(expected, actual);
        }
#endif
    }
}