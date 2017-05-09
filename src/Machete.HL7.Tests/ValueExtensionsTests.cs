﻿namespace Machete.Tests
{
    using NUnit.Framework;
    using HL7;
    using HL7.Tests.Segments;


    [TestFixture]
    public class ValueExtensionsTests
    {
        private IParser<HL7Entity> _parser;

        [OneTimeSetUp]
        public void Setup()
        {
            var schema = Schema.Factory.CreateHL7(x =>
            {
                x.Add(new MSGComponentMap());
                x.Add(new MSHSegmentMap());
                x.Add(new EVNSegmentMap());
            });

            _parser = Parser.Factory.CreateHL7(schema);
        }

        [Test]
        public void Verify_ValueOrEmpty_returns_empty_when_field_missing()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";

            Parsed<HL7Entity> parsed = _parser.Parse(message);

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

            Parsed<HL7Entity> parsed1 = _parser.Parse(message1);

            var query1 = parsed1.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result1 = parsed1.Query(query1);

            const string message2 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R02|K113|P|";

            Parsed<HL7Entity> parsed2 = _parser.Parse(message2);

            var query2 = parsed2.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result2 = parsed2.Query(query2);

            bool expected = true;
            bool actual = result1.Value.MessageType.Value.MessageCode.IsEqualTo(result2.Value.MessageType.Value.MessageCode.Value);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Verify_IsEqualTo_can_evaluate_component_field_correctly()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed1 = _parser.Parse(message1);

            var query1 = parsed1.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result1 = parsed1.Query(query1);

            const string message2 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R02|K113|P|";

            Parsed<HL7Entity> parsed2 = _parser.Parse(message2);

            var query2 = parsed2.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result2 = parsed2.Query(query2);

            bool expected = false;
            bool actual = result1.Value.MessageType.IsEqualTo(result2.Value.MessageType.Value);

            Assert.AreEqual(expected, actual);
        }
    }
}