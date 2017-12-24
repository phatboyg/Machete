namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class OrTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_can_return_missing_value_on_simple_typed_field()
        {
            const string message = @"MSH|^~\&|||MACHETE||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);

            Value<string> actual = result.Select(x => x.SendingApplication).Or(Value.Missing<string>());
            
            Assert.IsNotNull(actual);
            Assert.IsFalse(actual.HasValue);
            Assert.IsFalse(actual.IsPresent);
            Assert.AreEqual(Value.Missing<string>(), actual);
        }

        [Test, Explicit("Broken because of Issue #42")]
        public void Verify_can_return_missing_value_on_complex_typed_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);

            Value<MSG> actual = result.Select(x => x.MessageType).Or(Value.Missing<MSG>());
            
            Assert.IsNotNull(actual);
            Assert.IsFalse(actual.HasValue);
            Assert.IsFalse(actual.IsPresent);
        }

        [Test]
        public void Verify_can_return_value_on_simple_typed_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);

            Value<string> actual = result.Select(x => x.SendingApplication).Or(Value.Missing<string>());
            
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.IsEqualTo("LIFTLAB"));
        }

        [Test]
        public void Verify_can_return_value_on_complex_typed_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = entityResult.Query(query);

            Value<MSG> actual = result.Select(x => x.MessageType).Or(Value.Missing<MSG>());
            
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Select(X => X.MessageCode).IsEqualTo("ORU"));
            Assert.IsTrue(actual.Select(X => X.TriggerEvent).IsEqualTo("R01"));
        }
    }
}