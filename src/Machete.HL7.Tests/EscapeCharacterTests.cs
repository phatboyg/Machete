namespace Machete.HL7.Tests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;

    [TestFixture]
    public class EscapeCharacterTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test, Explicit("Not working until Issue #20 is fixed")]
        public void Test()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 A \T\ B STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            var parsed = Parser.Parse(message);
            var result = parsed.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select pid);

            string street = result
                .Get(x => x.PatientAddress, 0)
                .Get(x => x.StreetAddress)
                .Get(x => x.StreetName)
                .ValueOrDefault();
            
            Assert.AreEqual(@"123 A & B STREET", street);
        }
    }
}