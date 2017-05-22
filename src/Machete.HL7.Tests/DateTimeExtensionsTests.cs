namespace Machete.HL7.Tests
{
    using System;
    using Segments;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class DateTimeExtensionsTests :
        MacheteHL7TestContext<DateTimeSegment>
    {
        //IParser<HL7Entity> _parser;
        //[Test]
        //public void Verify_can_convert_DateTime_to_different_time_zone_given_TimeSpan()
        //{
        //    DateTime dt = new DateTime(2017, 5, 10, 15, 10, 35);
        //    TimeSpan offset = new TimeSpan(0, 8, 0, 0);
        //    DateTimeOffset expected = new DateTimeOffset(dt, offset);

        //    DateTimeOffset actual = dt.ConvertTo(offset);

        //    Assert.AreEqual(expected, actual);
        //}

        //    [OneTimeSetUp]
        //public void Setup()
        //{
        //    var schema = Schema.Factory.CreateHL7(cfg =>
        //    {
        //        cfg.Add(new DateTimeSegmentMap());
        //    });

        //    _parser = Parser.Factory.CreateHL7(schema);
        //}

        [Test]
        public void Verify_can_convert_DateTime_to_different_time_zone_given_TimeZoneInfo()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
ZHX|20170113|201705221530";

            //Parsed<HL7Entity> parsed = _parser.Parse(message);
            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zhx in q.Select<DateTimeSegment>()
                select new
                {
                    MSH = msh,
                    ZHX = zhx
                });

            var result = parsed.Query(query);

            //var dt = result.Value.TestDateTimeOffset;
            Value<DateTime> dt = result.Value.ZHX.TestDateTime;
            //DateTime dt = new DateTime(2017, 5, 10, 15, 10, 35);
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTime dateTime = dt.ValueOrDefault();
            DateTimeOffset expected = new DateTimeOffset(dateTime, offset);

            DateTimeOffset actual = dt.ConvertTo(offset);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Verify_can_convert_datetimeoffset_to_different_time_zone()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);
            //Parsed<HL7Entity> parsed = _parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            DateTimeOffset dt = result.Value.CreationDateTime.Value;
            var destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");
            DateTimeOffset expected = TimeZoneInfo.ConvertTime(dt, destinationTimeZone);
            DateTimeOffset actual = result.Value.CreationDateTime.ConvertTo(destinationTimeZone);

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

        //[Test]
        //public void Verify_()
        //{
        //    var destinationTimeZone = TimeZoneInfo.CreateCustomTimeZone("Pacific Standard Time", new TimeSpan(0, 8, 0, 0), "PST", "PST");
        //    DateTime dt = DateTime.UtcNow;

        //    Assert.Throws<ArgumentNullException>(() =>
        //    {
        //        var dateTime = dt.ConvertTo(null);
        //    });
        //}
    }
}