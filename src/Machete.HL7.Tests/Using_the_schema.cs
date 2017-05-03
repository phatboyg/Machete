namespace Machete.HL7.Tests
{
    using System;
    using System.Threading.Tasks;
    using HL7Schema.V26;
    using NUnit.Framework;


    [TestFixture]
    public class Using_the_schema
    {
        ISchema<HL7Entity> _schema;
        IParser<HL7Entity> _parser;

        [OneTimeSetUp]
        public void Setup()
        {
            _schema = Schema.Factory.CreateHL7(cfg =>
            {
                // Add all the types
                cfg.AddFromNamespaceContaining<HL7Schema.V26.MSH>();
            });

            _parser = Parser.Factory.CreateHL7(_schema);
        }

        [Test]
        public void Should_create_the_parser()
        {
        }

        [Test]
        public async Task Should_parse_a_segment_and_parse_into_the_component()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSH>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});


            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MC, Is.EqualTo("ORU"));
            Assert.That(result.Value.TE, Is.EqualTo("R01"));
        }

        [Test]
        public async Task Should_parse_a_series_of_segments()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSH>()
                from evn in q.Select<EVN>()
                select new {MSH = msh, EVN = evn});

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Value.EVN, Is.Not.Null);
            Assert.That(result.Value.EVN.RecordedDateTime.Value, Is.EqualTo(new DateTimeOffset(2017, 1, 13, 12, 34, 0, TimeSpan.Zero)));
        }

    }
}