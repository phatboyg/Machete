namespace Machete.HL7.Tests.DataTypeParsingTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class NATests :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public void Should_be_possible()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
NAX|125^34^-22^-234^569^442^-212^6|1.2^-3.5^5.2~2.0^3.1^-6.2~3.5^7.8^-1.3|^2^3^4~5^^^8~9^10~~17^18^19^20";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from nas in q.Select<NumericArraySegment>()
                select nas);

            var result = entityResult.Query(query);

            decimal value1 = result.Select(x => x.Array1).Select(x => x.Value1).ValueOrDefault();
            decimal value2 = result.Select(x => x.Array1).Select(x => x.Value2).ValueOrDefault();
            decimal value3 = result.Select(x => x.Array1).Select(x => x.Value3).ValueOrDefault();
            decimal value4 = result.Select(x => x.Array1).Select(x => x.Value4).ValueOrDefault();
            
            Assert.AreEqual(125, value1);
            Assert.AreEqual(34, value2);
            Assert.AreEqual(-22, value3);
            Assert.AreEqual(-234, value4);
        }
    }
}