namespace Machete.HL7.Tests
{
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Segments;


    [TestFixture]
    public class Querying_a_schema
    {
        ISchema<HL7Entity> _schema;
        IParser<HL7Entity> _parser;

        [OneTimeSetUp]
        public void Setup()
        {
            _schema = Schema.Factory.CreateHL7(cfg =>
            {
                cfg.Add(new MSGComponentMap());
                cfg.Add(new MSHSegmentMap());
                cfg.Add(new EVNSegmentMap());
            });

            _parser = Parser.Factory.CreateHL7(_schema);
        }

        [Test]
        public async Task Should_be_possible()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
        }

        [Test]
        public async Task Should_parse_a_series_of_segments()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Value.EVN, Is.Not.Null);
        }

        [Test]
        public async Task Should_be_able_to_skip_segments_via_selection()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var result = parsed.Query(q =>
                from ignored in q.Except<HL7Segment, EVNSegment>().ZeroOrMore()
                from segment in q.Select<EVNSegment>()
                where segment.EntityType.IsUnknown == false
                select new {segment, ignored});

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.segment.SegmentId, Is.Not.Null);
            Assert.That(result.Value.segment.SegmentId.HasValue, Is.True);
            Assert.That(result.Value.segment.SegmentId.Value, Is.EqualTo("EVN"));

            Assert.That(result.Value.ignored.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task Should_parse_a_series_of_segments_using_optional()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>().FirstOrDefault()
                select new {MSH = msh, EVN = evn});

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Value.EVN, Is.Null);
        }

        [Test]
        public async Task Should_parse_a_series_of_segments_but_not_match()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            Assert.That(result.HasValue, Is.False);
        }

        [Test]
        public async Task Should_parse_a_segment_and_parse_into_the_component()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});


            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MC, Is.EqualTo("ORU"));
            Assert.That(result.Value.TE, Is.EqualTo("R01"));
        }
    }
}