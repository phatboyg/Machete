namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;


    [TestFixture]
    public class ValueListTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_parse_component_typed_ValueList()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026^^^KNIFE1|60043^^^MACHETE1^MRN~60044^^^MACHETE2^MRN~60045^^^MACHETE3^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from pid in q.Select<PIDSegment>()
                select pid);

            Assert.IsTrue(result.Select(x => x.PatientId).HasValue);
            Assert.IsTrue(result.Select(x => x.PatientId).Select(x => x.IdNumber).HasValue);
            Assert.That(result.Select(x => x.PatientId).Select(x => x.IdNumber).ValueOrDefault(), Is.EqualTo("000000000026"));
            Assert.IsTrue(result.Select(x => x.PatientId).Select(x => x.AssigningAuthority).HasValue);
            Assert.That(result.Select(x => x.PatientId).Select(x => x.AssigningAuthority).Slice.Text.ToString(), Is.EqualTo("KNIFE1"));
            Assert.That(result.Select(x => x.PatientId).Select(x => x.AssigningAuthority).Select(x => x.NamespaceId).HasValue, Is.True);
            Assert.That(result.Select(x => x.PatientId).Select(x => x.AssigningAuthority).Select(x => x.NamespaceId).ValueOrDefault(), Is.EqualTo("KNIFE1"));
            Assert.IsNotNull(result.Select(x => x.PatientIdentifierList));
            Assert.IsTrue(result.Select(x => x.PatientIdentifierList).HasValue);

            Value<CXComponent> id = result.Select(x => x.PatientIdentifierList)[0];

            Assert.IsTrue(id.HasValue);
            Assert.IsTrue(id.Select(x => x.IdNumber).HasValue);
            Assert.AreEqual("60043", id.Select(x => x.IdNumber).ValueOrDefault());
            Assert.IsTrue(id.Select(x => x.AssigningAuthority).HasValue);
            Assert.That(id.Select(x => x.AssigningAuthority).Slice.Text.ToString(), Is.EqualTo("MACHETE1"));
            Assert.IsTrue(id.Select(x => x.AssigningAuthority).Select(x => x.NamespaceId).HasValue);
            Assert.AreEqual("MACHETE1", id.Select(x => x.AssigningAuthority).Select(x => x.NamespaceId).ValueOrDefault());
            Assert.IsTrue(id.Select(x => x.IdentifierTypeCode).HasValue);
            Assert.AreEqual("MRN", id.Select(x => x.IdentifierTypeCode).ValueOrDefault());
        }

        [Test]
        public void Should_be_able_to_parse_primitive_typed_ValueList()
        {
            const string message1 = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message1);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            string actual = result.Select(x => x.RepeatedString)[0].ValueOrDefault();

            Assert.AreEqual("ABC", actual);
            Assert.That(result.Select(x => x.RepeatedComplexType)[0], Is.Not.Null);
            Assert.That(result.Select(x => x.RepeatedComplexType)[0].HasValue, Is.True);

            string actualId = result.Select(x => x.RepeatedComplexType[0]).Select(x => x.IdNumber).ValueOrDefault();

            Assert.AreEqual("ABC", actualId);
        }

        [Test]
        public void Should_be_able_to_count_ValueList()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            Assert.That(result.Select(x => x.RepeatedComplexType).HasValue, Is.True);
            Assert.AreEqual(3, result.Select(x => x.RepeatedComplexType).Count());
        }

        [Test]
        public void Should_be_able_to_()
        {
            const string message = @"MSH|^~\&|LIFTLAB||MACHETE||201701131234||ORU^R01|K113|P|
VL1|ABC~XYZ~123|ABC~XYZ~123";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from vl1 in q.Select<ValueListSegment>()
                select vl1);

            var result = parsed.Query(query);

            Assert.That(result.Select(x => x.RepeatedComplexType).HasValue, Is.True);
            Assert.AreEqual(3, result.Select(x => x.RepeatedComplexType).Count());

            string ct1 = result.Select(x => x.RepeatedComplexType)[0].Select(x => x.IdNumber).ValueOrDefault();
            string ct2 = result.Select(x => x.RepeatedComplexType)[1].Select(x => x.IdNumber).ValueOrDefault();
            string ct3 = result.Select(x => x.RepeatedComplexType)[2].Select(x => x.IdNumber).ValueOrDefault();
            
            Assert.AreEqual("ABC", ct1);
            Assert.AreEqual("XYZ", ct2);
            Assert.AreEqual("123", ct3);
        }
    }
}