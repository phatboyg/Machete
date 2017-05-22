namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;

    
    [TestFixture]
    public class ValueDefaultExtensionsTests :
        MacheteHL7TestContext
    {
        public ValueDefaultExtensionsTests()
            : base(Machete.Schema.Factory.CreateHL7(x =>
            {
                x.Add(new MSGComponentMap());
                x.Add(new MSHSegmentMap());
                x.Add(new EVNSegmentMap());
            }))
        {
        }
        
        [Test]
        public void Verify_()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            var messageType = result.Value.MessageType.ValueOrDefault(null);
            
            Assert.IsNull(messageType);
        }

        [Test]
        public void Should_()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            string messageType = result.Value.MessageType.Value.MessageCode.ValueOrDefault("ORU");
            
            Assert.AreEqual("ORU", messageType);
        }
    }
}