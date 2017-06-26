﻿namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;

    [TestFixture]
    public class GetValueExtensionsTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_Get_can_safely_return_value()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message1);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            string actual = result.Get(x => x.ReceivingApplication).ValueOrDefault();

            Assert.AreEqual("MACHETE", actual);
        }

        [Test]
        public void Verify_Get_can_safely_return_value_from_component()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message1);

            var query = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(query);

            string actual = result.Get(x => x.MessageType).Get(x => x.MessageCode).ValueOrDefault();

            Assert.AreEqual("ORU", actual);
        }

        [Test, Explicit("Not working until Issue #20 is fixed")]
        public void Verify_Get_can_safely_return_value_from_array_component()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123";

            Parsed<HL7Entity> parsed = Parser.Parse(message1);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            string actual = result.Get(x => x.RepeatedString, 1).ValueOrDefault();

            Assert.AreEqual("XYZ", actual);
        }
    }
}