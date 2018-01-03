namespace Machete.HL7.Tests.ValueConversionTests
{
    using System;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ConvertDateTimeTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_convert_DateTime_to_DateTimeOffset_with_offset()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
ZDT|20170113";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zdt in q.Select<DateTimeSegment>()
                select zdt);

            var result = entityResult.Query(query);

            Value<DateTime> dt = result.Result.TestDateTime;
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset dateTime = dt.ValueOrDefault();
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime, offset);

            DateTimeOffset actual = dt.ToDateTimeOffset(offset).ValueOrDefault();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_be_able_to_convert_DateTime_to_DateTimeOffset()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
ZDT|20170113";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zdt in q.Select<DateTimeSegment>()
                select zdt);

            var result = entityResult.Query(query);

            Value<DateTime> dt = result.Result.TestDateTime;
            DateTimeOffset dateTime = dt.ValueOrDefault();
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime);

            DateTimeOffset actual = dt.ToDateTimeOffset().ValueOrDefault();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_be_able_to_convert_DateTime_with_time_component_to_DateTimeOffset_with_offset()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
ZDT|201705221530";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zdt in q.Select<DateTimeSegment>()
                select zdt);

            var result = entityResult.Query(query);

            Value<DateTime> dt = result.Result.TestDateTime;
            TimeSpan offset = new TimeSpan(0, 8, 0, 0);
            DateTimeOffset dateTime = dt.ValueOrDefault();
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime, offset);

            DateTimeOffset actual = dt.ToDateTimeOffset(offset).ValueOrDefault();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_be_able_to_convert_DateTime_with_time_component_to_DateTimeOffset()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
ZDT|201705221530";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zdt in q.Select<DateTimeSegment>()
                select zdt);

            var result = entityResult.Query(query);

            Value<DateTime> dt = result.Result.TestDateTime;
            DateTimeOffset dateTime = dt.ValueOrDefault();
            DateTimeOffset expected = new DateTimeOffset(dateTime.DateTime);

            DateTimeOffset actual = dt.ToDateTimeOffset().ValueOrDefault();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_throw_ArgumentNullException_when_Value_is_null()
        {
            Value<DateTime> dt = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                DateTimeOffset actual = dt.ToDateTimeOffset().ValueOrDefault();
            });
        }
    }
}