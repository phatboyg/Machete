namespace Machete.HL7.Tests.QueryTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class OptionalQueryTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_parse_missing_segment_optionally()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                from evn in q.Select<EVN>().Optional()
                select new {MSH = msh, EVN = evn});

            var query = entityResult.Query(mshSegmentQuery);

            Assert.IsNull(query.Result.EVN);
        }
    }
}