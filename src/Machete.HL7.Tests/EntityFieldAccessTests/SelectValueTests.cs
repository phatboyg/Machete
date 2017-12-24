namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class SelectValueTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_Select_can_safely_return_value_from_simple_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                select msh);

            var result = parsed.Query(query);

            Value<string> receivingApplication = result.Select(x => x.ReceivingApplication);

            Assert.IsNotNull(receivingApplication);
            Assert.AreNotEqual(Value.Empty<string>(), receivingApplication);
            Assert.AreNotEqual(Value.Missing<string>(), receivingApplication);
            Assert.AreEqual("MACHETE", receivingApplication.ValueOrDefault());
        }

        [Test]
        public void Verify_Select_return_empty_value_from_simple_field()
        {
            const string message = @"MSH|^~\&|||MACHETE||201701131234||ORU^R01|K113|P|";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                select msh);

            var result = parsed.Query(query);

            Value<string> sendingApplication = result.Select(x => x.SendingApplication);

            Assert.IsNotNull(sendingApplication);
            Assert.IsFalse(sendingApplication.HasValue);
            Assert.IsTrue(sendingApplication.IsPresent);
            Assert.AreNotEqual(Value.Empty<string>(), sendingApplication);
            Assert.AreNotEqual(Value.Missing<string>(), sendingApplication);
        }
        
        [Test]
        public void Verify_Select_return_empty_value_from_complex_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^|K113|P|";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                select msh);

            var result = parsed.Query(query);

            Value<MSG> messageType = result.Select(x => x.MessageType);
            Value<string> messageCode = messageType.Select(x => x.MessageCode);

            Assert.IsNotNull(messageType);
            Assert.IsNotNull(messageCode);
            Assert.AreNotEqual(Value.Empty<string>(), messageType);
            Assert.AreNotEqual(Value.Missing<string>(), messageType);
            Assert.AreNotEqual(Value.Empty<string>(), messageCode);
        }
        
        [Test]
        public void Verify_Select_can_safely_return_value_from_complex_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                select msh);

            var result = parsed.Query(query);

            Value<MSG> messageType = result.Select(x => x.MessageType);
            Value<string> messageCode = messageType.Select(x => x.MessageCode);

            Assert.IsNotNull(messageType);
            Assert.IsNotNull(messageCode);
            Assert.AreNotEqual(Value.Empty<string>(), messageType);
            Assert.AreNotEqual(Value.Missing<string>(), messageType);
            Assert.AreNotEqual(Value.Empty<string>(), messageCode);
            Assert.AreNotEqual(Value.Missing<string>(), messageCode);
            Assert.AreEqual("ORU", messageCode.ValueOrDefault());
        }
    }
}