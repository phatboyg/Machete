namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ValueListCountTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_count_items_in_list()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            Assert.IsTrue(result.Select(x => x.RepeatedComplexType).HasValue);
            Assert.AreEqual(3, result.Select(x => x.RepeatedComplexType).Count());
        }

        [Test]
        public void Should_be_able_to_return_zero_count_for_missing_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            Assert.IsTrue(result.Select(x => x.RepeatedComplexType).HasValue);
            Assert.AreEqual(0, result.Select(x => x.RepeatedComplexType).Count());
        }
    }
}