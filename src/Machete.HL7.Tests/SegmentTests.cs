namespace Machete.HL7.Tests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class SegmentTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_get_fields()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN~60044^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select pid);

            string patientIdentifierList = result.Select(x => x.Fields)[2].ValueOrDefault();

            Assert.AreEqual("60043^^^MACHETE^MRN~60044^^^MACHETE^MRN", patientIdentifierList);
        }
    }
}