namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ValueOrEmptyTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_ValueOrEmpty_returns_empty_when_field_missing()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);

            Assert.AreEqual(string.Empty, result.Select(x => x.MessageType).Select(x => x.MessageCode).ValueOrEmpty());
        }

        [Test]
        public void Verify_ValueOrEmpty_returns_value_when_data_present()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);

            Assert.AreEqual("LIFTLAB", result.Select(x => x.SendingApplication).ValueOrEmpty());
        }
    }
}