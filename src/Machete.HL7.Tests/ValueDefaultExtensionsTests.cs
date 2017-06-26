namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;

    
    [TestFixture]
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

            var messageType = result.Value.MessageType.Value;
            string messageCode = messageType.MessageCode.ValueOrDefault("ORU");
            
            Assert.IsNotNull(messageType);
            Assert.That(messageType.MessageCode.HasValue, Is.False);
            Assert.AreEqual("ORU", messageCode);
        }
    }
}