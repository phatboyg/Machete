namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;

    
    public class ValueDefaultExtensionsTests :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public void Should_be_possible()
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
    }
}