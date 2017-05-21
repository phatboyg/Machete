namespace Machete.HL7.Tests
{
    using System;
    using Segments;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class DateTimeExtensionsTests :
        MacheteHL7TestContext
    {
        public DateTimeExtensionsTests()
            : base(Machete.Schema.Factory.CreateHL7(x =>
            {
                x.Add(new MSGComponentMap());
                x.Add(new MSHSegmentMap());
                x.Add(new EVNSegmentMap());
            }))
        {
        }

        [Test]
        public void Verify_can_convert_DateTime_to_different_time_zone_given_TimeSpan()
        {
            DateTime dt = new DateTime(2017, 5, 10, 15, 10, 35);
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset expected = new DateTimeOffset(dt, offset);

            DateTimeOffset actual = dt.ConvertTo(offset);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Verify_can_convert_DateTime_to_different_time_zone_given_TimeZoneInfo()
        {
            DateTime dt = new DateTime(2017, 5, 10, 15, 10, 35);
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset expected = new DateTimeOffset(dt, offset);

            DateTimeOffset actual = dt.ConvertTo(offset);

            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void Verify_can_convert_DateTime_to_different_time_zone_given_TimeZoneInfo()
        //{
        //    DateTime dt = new DateTime(2017, 5, 10, 15, 10, 35);
        //    var destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");
        //    DateTimeOffset expected = TimeZoneInfo.ConvertTime(dt, destinationTimeZone);

        //    DateTimeOffset actual = dt.ConvertTo(destinationTimeZone);

        //    Assert.AreEqual(expected, actual);
        //}

        [Test]
        public void Verify_can_convert_datetimeoffset_to_different_time_zone()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            DateTimeOffset dt = result.Value.CreationDateTime.Value;
            var destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");
            DateTimeOffset expected = TimeZoneInfo.ConvertTime(dt, destinationTimeZone);
            DateTimeOffset actual = result.Value.CreationDateTime.Value.ConvertTo(destinationTimeZone);

            Assert.AreEqual(expected, actual);
        }

//        [Test]
//        public void Verify_()
//        {
//            var destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");
//            DateTime dt = DateTime.UtcNow;
//
//            Assert.Throws<ArgumentNullException>(() =>
//            {
//                var dateTime = dt.ConvertTo(null);
//            });
//        }
    }
}