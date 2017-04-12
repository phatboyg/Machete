namespace Machete.HL7.Tests
{
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Parsers;
    using Segments;
    using Texts;


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

            var text = new StringText(message);

            Parsed<HL7Entity> parsed = _parser.Parse(text, new TextSpan(0, text.Length));

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var query = Query<HL7Entity>.Create(q =>
                from x in q.Select<MSHSegment>()
                from y in q.Select<MSG>()
                select new {x.MessageType, y.MessageCode});

            var cursor = parsed.GetCursor();

            var result = mshSegmentQuery.Parse(cursor);

            Assert.That(result.HasValue, Is.True);
        }

        [Test]
        public async Task Should_parse_a_series_of_segments()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            var text = new StringText(message);

            Parsed<HL7Entity> parsed = _parser.Parse(text, new TextSpan(0, text.Length));

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new { MSH = msh, EVN = evn});

            var cursor = parsed.GetCursor();

            var result = mshSegmentQuery.Parse(cursor);

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Value.EVN, Is.Not.Null);
        }

        [Test]
        public async Task Should_parse_a_series_of_segments_using_optional()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            Parsed<HL7Entity> parsed = _parser.Parse(text, new TextSpan(0, text.Length));

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>().FirstOrDefault()
                select new { MSH = msh, EVN = evn});

            var cursor = parsed.GetCursor();

            var result = mshSegmentQuery.Parse(cursor);

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

            var text = new StringText(message);

            Parsed<HL7Entity> parsed = _parser.Parse(text, new TextSpan(0, text.Length));

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new { MSH = msh, EVN = evn});

            var cursor = parsed.GetCursor();

            var result = mshSegmentQuery.Parse(cursor);

            Assert.That(result.HasValue, Is.False);
        }
    }
}