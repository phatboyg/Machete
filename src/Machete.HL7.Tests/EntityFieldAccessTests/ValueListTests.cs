namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ValueListTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_parse_simple_list()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            var simpleValue = result.Select(x => x.RepeatedString)[0];

            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(simpleValue);
            Assert.AreEqual("ABC", simpleValue.ValueOrDefault());
        }

        [Test]
        public void Should_be_able_to_parse_complex_list()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message1);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);
            
            Assert.IsTrue(result.HasResult);
            
            var complexValue = result.Select(x => x.RepeatedComplexType)[0];
            
            Assert.IsNotNull(complexValue);
            Assert.IsTrue(complexValue.HasValue);
            Assert.AreEqual("ABC", complexValue.Select(x => x.IdNumber).ValueOrDefault());
        }

        [Test]
        public void Should_throw_exception_when_index_out_of_range()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            Assert.That(result.Select(x => x.RepeatedComplexType).HasValue, Is.True);
            Assert.AreEqual(3, result.Select(x => x.RepeatedComplexType).Count());
            
            Assert.Throws<ValueOutOfRangeException>(() =>
            {
                CXComponent cx = result.Select(x => x.RepeatedComplexType)[4].Value;
            });
        }
    }
}