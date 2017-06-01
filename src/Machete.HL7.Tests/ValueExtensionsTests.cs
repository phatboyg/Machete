namespace Machete.HL7.Tests
{
    using HL7;
    using NUnit.Framework;
    using Segments;
    using Testing;

    
    [TestFixture]
    public class ValueExtensionsTests :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public void Verify_ValueOrEmpty_returns_empty_when_field_missing()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            Assert.AreEqual(string.Empty, result.Value.MessageType.Value.MessageCode.ValueOrEmpty());
        }

        [Test]
        public void Verify_IsEqualTo_can_evaluate_subcomponent_field_correctly()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed1 = Parser.Parse(message1);

            var query1 = parsed1.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result1 = parsed1.Query(query1);

            const string message2 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R02|K113|P|";

            Parsed<HL7Entity> parsed2 = Parser.Parse(message2);

            var query2 = parsed2.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result2 = parsed2.Query(query2);

            bool actual = result1.Value.MessageType.Value.MessageCode.IsEqualTo(result2.Value.MessageType.Value.MessageCode.Value);

            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Verify_IsEqualTo_can_evaluate_component_field_correctly()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed1 = Parser.Parse(message1);

            var query1 = parsed1.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result1 = parsed1.Query(query1);

            const string message2 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R02|K113|P|";

            Parsed<HL7Entity> parsed2 = Parser.Parse(message2);

            var query2 = parsed2.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result2 = parsed2.Query(query2);

            bool actual = result1.Value.MessageType.IsEqualTo(result2.Value.MessageType.Value);

            Assert.AreEqual(false, actual);
        }
    }
}