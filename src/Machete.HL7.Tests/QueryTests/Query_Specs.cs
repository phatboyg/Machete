namespace Machete.HL7.Tests.QueryTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class Querying_a_schema :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_possible()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(mshSegmentQuery);

            Assert.That(result.HasResult, Is.True);
        }

        [Test]
        public void Should_not_blow_up()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(mshSegmentQuery);

            Assert.That(result.HasResult, Is.True);
        }

        [Test]
        public void Should_throw_ValueMissingException()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select new {x.MessageType, x});

            var result = entityResult.Query(query);

            Assert.That(result.HasResult, Is.True);
            Assert.Throws<ValueEmptyException>(() =>
            {
                string messageCode = result.Result.MessageType.Value.MessageCode.Value;
            });

            Assert.Throws<ValueMissingException>(() =>
            {
                string messageCode = result.Result.x.ReceivingNetworkAddress.Value;
            });
        }

        [Test]
        public void Should_parse_a_series_of_segments()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            var result = entityResult.Query(mshSegmentQuery);

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Result.MSH, Is.Not.Null);
            Assert.That(result.Result.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Result.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Result.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Result.EVN, Is.Not.Null);
        }

        [Test]
        public void Should_be_able_to_skip_segments_via_selection()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from ignored in q.Except<HL7Segment, EVNSegment>().ZeroOrMore()
                from segment in q.Select<EVNSegment>()
                where segment.EntityInfo.IsDefined
                select new {segment, ignored});

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Result.segment.SegmentId, Is.Not.Null);
            Assert.That(result.Result.segment.SegmentId.HasValue, Is.True);
            Assert.That(result.Result.segment.SegmentId.Value, Is.EqualTo("EVN"));

            Assert.That(result.Result.ignored.Count, Is.EqualTo(1));

            Assert.That(result.Result.ignored[0].SegmentId.Value, Is.EqualTo("MSH"));
        }

        [Test]
        public void Should_parse_a_series_of_segments_using_optional()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>().Optional()
                select new {MSH = msh, EVN = evn});

            var result = entityResult.Query(mshSegmentQuery);

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Result.MSH, Is.Not.Null);
            Assert.That(result.Result.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Result.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Result.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Result.EVN, Is.Null);
        }

        [Test]
        public void Should_parse_a_series_of_segments_but_not_match()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            Assert.That(result.HasResult, Is.False);
        }

        [Test]
        public void Should_parse_a_segment_and_parse_into_the_component()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Result.MC, Is.EqualTo("ORU"));
            Assert.That(result.Result.TE, Is.EqualTo("R01"));
        }
    }
}