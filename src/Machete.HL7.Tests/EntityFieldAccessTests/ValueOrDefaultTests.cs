namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ValueOrDefaultTests :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public void Should_return_specified_default_value()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);
            
            Assert.That(result.Select(x => x.MessageType), Is.Not.Null);
            Assert.That(result.Select(x => x.MessageType).Select(x => x.MessageCode).HasValue, Is.False);
            Assert.AreEqual("ORU", result.Select(x => x.MessageType).Select(x => x.MessageCode).ValueOrDefault("ORU"));
        }
        
        [Test]
        public void Should_return_empty_string()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);
            
            Assert.That(result.Select(x => x.MessageType), Is.Not.Null);
            Assert.That(result.Select(x => x.MessageType).Select(x => x.MessageCode).HasValue, Is.False);
            Assert.IsNull(result.Select(x => x.MessageType).Select(x => x.MessageCode).ValueOrDefault());
        }
    }
}