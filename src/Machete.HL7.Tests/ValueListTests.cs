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

            Assert.IsTrue(result.Value.PatientId.HasValue);
            Assert.IsTrue(result.Value.PatientId.Value.IdNumber.HasValue);
            Assert.That(result.Value.PatientId.Value.IdNumber.Value, Is.EqualTo("000000000026"));
            Assert.IsTrue(result.Value.PatientId.Value.AssigningAuthority.HasValue);

            Assert.That(result.Value.PatientId.Value.AssigningAuthority.Slice.Text.ToString(), Is.EqualTo("KNIFE1"));

            Assert.That(result.Value.PatientId.Value.AssigningAuthority.Value.NamespaceId.HasValue, Is.True);
            Assert.That(result.Value.PatientId.Value.AssigningAuthority.Value.NamespaceId.Value, Is.EqualTo("KNIFE1"));

            Value<CXComponent> id;
            ValueList<CXComponent> patientIdentifierList = result.Value.PatientIdentifierList;
            Assert.IsNotNull(patientIdentifierList);
            Assert.IsTrue(patientIdentifierList.HasValue);

            Assert.IsTrue(patientIdentifierList.TryGetValue(0, out id));

            Assert.IsTrue(id.HasValue);
            Assert.IsTrue(id.Value.IdNumber.HasValue);
            Assert.AreEqual("60043", id.Value.IdNumber.Value);

            Assert.IsTrue(id.Value.AssigningAuthority.HasValue);
            Assert.That(id.Value.AssigningAuthority.Slice.Text.ToString(), Is.EqualTo("MACHETE1"));
            Assert.IsTrue(id.Value.AssigningAuthority.Value.NamespaceId.HasValue);
            Assert.AreEqual("MACHETE1", id.Value.AssigningAuthority.Value.NamespaceId.ValueOrDefault());

            Assert.IsTrue(id.Value.IdentifierTypeCode.HasValue);
            Assert.AreEqual("MRN", id.Value.IdentifierTypeCode.Value);
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

            Value<string> repeatedString;
            result.Value.RepeatedString.TryGetValue(0, out repeatedString);

            string actual = repeatedString.ValueOrDefault();

            Assert.AreEqual("ABC", actual);

            Value<CXComponent> complexType; 
            result.Value.RepeatedComplexType.TryGetValue(0, out complexType);

            Assert.That(complexType, Is.Not.Null);
            Assert.That(complexType.HasValue, Is.True);

            string actualId = complexType.Get(x => x.IdNumber).ValueOrDefault();

            Assert.AreEqual("ABC", actualId);

        }
    }
}