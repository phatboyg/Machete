namespace Machete.HL7.Tests
{
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Segments;


    [TestFixture]
    public class Using_a_template
    {
        ISchema<HL7Entity> _schema;
        IParser<HL7Entity> _parser;
        IStructure<HL7Entity> _structure;

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

            _structure = Structure.Factory.CreateHL7(_parser, cfg =>
            {
                cfg.Add(new MessageLayoutMap());
            });
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
    }
}