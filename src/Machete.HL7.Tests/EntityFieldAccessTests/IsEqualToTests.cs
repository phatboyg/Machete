namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using HL7;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class IsEqualToTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_IsEqualTo_can_evaluate_subcomponent_field_correctly()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> parsed1 = Parser.Parse(message1);

            var query1 = parsed1.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result1 = parsed1.Query(query1);

            const string message2 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R02|K113|P|";

            EntityResult<HL7Entity> parsed2 = Parser.Parse(message2);

            var query2 = parsed2.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result2 = parsed2.Query(query2);

            bool actual = result1
                .Select(x => x.MessageType)
                .Select(x => x.MessageCode)
                .IsEqualTo(result2.Select(x => x.MessageType).Select(x => x.MessageCode).Value);

            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Verify_IsEqualTo_can_evaluate_component_field_correctly()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> parsed1 = Parser.Parse(message1);

            var query1 = parsed1.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result1 = parsed1.Query(query1);

            const string message2 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R02|K113|P|";

            EntityResult<HL7Entity> parsed2 = Parser.Parse(message2);

            var query2 = parsed2.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result2 = parsed2.Query(query2);

            bool actual = result1.Select(x => x.MessageType).IsEqualTo(result2.Select(x => x.MessageType).Value);

            Assert.AreEqual(false, actual);
        }
    }
}