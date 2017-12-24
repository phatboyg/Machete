namespace Machete.HL7.Tests.ParserTests
{
    using System;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class Second_schema_user_should_use_static_value :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_create_the_parser()
        {
            Assert.IsNotNull(Parser);
        }
    }


    [TestFixture]
    public class Using_the_schema :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_create_the_parser()
        {
            Assert.IsNotNull(Parser);
        }

        [Test]
        public void Should_parse_a_segment_and_parse_into_the_component()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});


            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Result.MC, Is.EqualTo("ORU"));
            Assert.That(result.Result.TE, Is.EqualTo("R01"));
        }

        [Test]
        public void Should_include_value_info_in_the_entity_info()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});


            Assert.That(result.HasResult, Is.True);

            Assert.That(result.Result.MSH.EntityInfo, Is.Not.Null);
            Assert.That(result.Result.MSH.TryGetValueInfo(x => x.SegmentId, out var segmentIdValueInfo), Is.True);
            Assert.That(segmentIdValueInfo.ValueType, Is.EqualTo(typeof(string)));
            Assert.That(segmentIdValueInfo.IsRequired, Is.True);

            Assert.That(result.Result.MSH.TryGetValueInfo(x => x.MessageType, out var messageTypeValueInfo), Is.True);
            Assert.That(messageTypeValueInfo.ValueType, Is.EqualTo(typeof(MSG)));
            Assert.That(messageTypeValueInfo.IsRequired, Is.True);
        }

        [Test]
        public void Should_parse_a_series_of_segments()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                from evn in q.Select<EVN>()
                select new {MSH = msh, EVN = evn});

            var result = entityResult.Query(mshSegmentQuery);

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Result.MSH, Is.Not.Null);
            Assert.That(result.Result.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Result.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Result.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Result.EVN, Is.Not.Null);
            Assert.That(result.Result.EVN.RecordedDateTime.Value, Is.EqualTo(new DateTimeOffset(2017, 1, 13, 12, 34, 0, DateTimeOffset.Now.Offset)));
        }
    }
}