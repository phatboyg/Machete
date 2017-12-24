namespace Machete.HL7.Tests.DataTypeParsingTests
{
    using System;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class DateTimeOffsetParsingWithOffsetTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
#if !NETCORE
        [Test, Explicit("Need to figure out what is the issue here.")]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_tenth_millionth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.6175425-07:00";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.6175425-07:00"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }
#endif

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_millionth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.617542-07:00";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.617542-07:00"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_hundred_thousandth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.61754-07:00";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.61754-07:00"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_ten_thousandth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.5275-07:00";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.5275-07:00"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.617-07:00";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.617-07:00"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_hundred()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.61-07:00";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.61-07:00"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_tenth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.6-07:00";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.6-07:00"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }
    }
}