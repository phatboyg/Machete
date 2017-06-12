namespace Machete.HL7.Tests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;

    [TestFixture]
    public class ValueListTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test, Explicit("This test should be working but is not because TryGetValue on ValueList not working properly. Issue #20")]
        public void Should_be_possible()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE1^MRN~60044^^^MACHETE2^MRN~60045^^^MACHETE3^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select pid);

            var result = parsed.Query(query);

            Value<CX> id;
            ValueList<CX> patientIdentifierList = result.Value.PatientIdentifierList;
            bool actualResult = patientIdentifierList.TryGetValue(0, out id);

            Assert.IsNotNull(patientIdentifierList);
            Assert.IsTrue(patientIdentifierList.HasValue);
            //Assert.IsNotEmpty(patientIdentifierList);
            Assert.IsTrue(actualResult);
            Assert.AreEqual("60043", id.Value.IdNumber.ValueOrDefault());
            Assert.AreEqual("MACHETE1", id.Value.AssigningAuthority.Value.NamespaceId);
            Assert.AreEqual("MRN", id.Value.IdentifierTypeCode.ValueOrDefault());
        }
    }
}