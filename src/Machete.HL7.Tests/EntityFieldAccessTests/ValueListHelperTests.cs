namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ValueListHelperTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_flatten_list_of_list()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|1~2~3|ABC~XYZ~123
VL1|4~5~6|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>().ZeroOrMore()
                select vl1);

            var result = parsed.Query(query);

            IEnumerable<Value<string>> valueList = result.Result.Select(x => x.RepeatedString).ToEnumerable();
            
            Assert.AreEqual(6, valueList.Count());
            Assert.IsNotNull(valueList);
            Assert.AreEqual("1", valueList.ElementAt(0).ValueOrDefault());
            Assert.AreEqual("2", valueList.ElementAt(1).ValueOrDefault());
            Assert.AreEqual("3", valueList.ElementAt(2).ValueOrDefault());
            Assert.AreEqual("4", valueList.ElementAt(3).ValueOrDefault());
            Assert.AreEqual("5", valueList.ElementAt(4).ValueOrDefault());
            Assert.AreEqual("6", valueList.ElementAt(5).ValueOrDefault());
        }

        [Test]
        public void Should_be_able_to_empty_flattened_list_of_list()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>().ZeroOrMore()
                select vl1);

            var result = parsed.Query(query);

            IEnumerable<Value<string>> valueList = result.Result.Select(x => x.RepeatedString).ToEnumerable();
            
            Assert.AreEqual(0, valueList.Count());
            Assert.IsNotNull(valueList);
        }

        [Test]
        public void Should_be_able_perform_Count_on_ValueList()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|1~2~3|ABC~XYZ~123
VL1|4~5~6|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>().ZeroOrMore()
                select vl1);

            var result = parsed.Query(query);

            IEnumerable<ValueList<string>> valueList = result.Result.Select(x => x.RepeatedString);

            foreach (var list in valueList)
            {
                Assert.AreEqual(3, list.Count());
            }
        }

        [Test]
        public void Should_be_able_return_zero_count_on_ValueList()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";
            
            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>().ZeroOrMore()
                select vl1);

            var result = parsed.Query(query);

            IEnumerable<ValueList<string>> valueList = result.Result.Select(x => x.RepeatedString);

            foreach (var list in valueList)
            {
                Assert.AreEqual(0, list.Count());
            }
        }
    }
}