namespace Machete.HL7.Tests.DataTypeParsingTests
{
    using System;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class DateTimeOffsetParsingWithoutOffsetTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
#if !NETCORE
        [Test, Explicit("Need to figure out what is the issue here.")]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_tenth_millionth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.6175425";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.6175425"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }
#endif

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_millionth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.617542";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.617542"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_hundred_thousandth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.61754";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.61754"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_ten_thousandth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.5275";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.5275"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test, Explicit("For some reason this is not working. Needs investigation")]
        public void Verify_can_convert_DateTimeOffset_with_millisecond()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.617";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.617"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_hundred()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.61";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.61"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_with_millisecond_tenth()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600.6";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(DateTimeOffset.Parse("2017-12-22T17:06:00.6"),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_without_millisecond()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222170600";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(new DateTimeOffset(new DateTime(2017, 12, 22, 17, 6, 0)),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_without_seconds()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||201712221706";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(new DateTimeOffset(new DateTime(2017, 12, 22, 17, 6, 0)),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }

        [Test]
        public void Verify_can_convert_DateTimeOffset_without_time()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||20171222";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(new DateTimeOffset(new DateTime(2017, 12, 22)),
                result.Select(x => x.DateTimeOffsetField).ValueOrDefault());
        }
    }
}