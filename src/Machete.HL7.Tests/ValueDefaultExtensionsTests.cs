namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;

    
    [TestFixture]
    public class ValueDefaultExtensionsTests :
        MacheteHL7TestContext<MSHSegment>
    {
        [Test]
        public void Should_be_possible()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            var messageType = result.Value.MessageType.Value;
            string messageCode = messageType.MessageCode.ValueOrDefault("ORU");
            
            Assert.IsNotNull(messageType);
            Assert.That(messageType.MessageCode.HasValue, Is.False);
            Assert.AreEqual("ORU", messageCode);
        }
    }
}