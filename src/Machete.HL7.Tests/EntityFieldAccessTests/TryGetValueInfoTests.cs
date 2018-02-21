namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class TryGetValueInfoTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_include_value_info_in_the_entity_info()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});

            Assert.That(result.HasResult, Is.True);

            Assert.That(result.Result.MSH.EntityInfo, Is.Not.Null);
            Assert.That(result.Result.MSH.TryGetValueInfo(x => x.SegmentId, out var segmentIdValueInfo), Is.True);
            Assert.That(segmentIdValueInfo.ValueType, Is.EqualTo(typeof(string)));
            Assert.That(segmentIdValueInfo.IsRequired, Is.True);

            Assert.That(result.Result.MSH.TryGetValueInfo(x => x.MessageType, out var messageTypeValueInfo), Is.True);
            Assert.That(messageTypeValueInfo.ValueType, Is.EqualTo(typeof(MSG)));
            Assert.That(messageTypeValueInfo.IsRequired, Is.True);
        }

        [Test]
        public void Should_not_throw_exception_when_segment_field_is_null()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});

            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(result.Result.MSH.EntityInfo);
            Assert.IsFalse(result.Result.MSH.TryGetValueInfo<MSH, Value<MSG>>(null, out var info));
            Assert.IsFalse(info.HasValue);
        }

        [Test]
        public void Should_not_throw_exception_when_segment_is_null()
        {
            MSH segment = null;
            
            Assert.IsFalse(segment.TryGetValueInfo(x => x.MessageType, out var info));
            Assert.IsFalse(info.HasValue);
        }
    }
}