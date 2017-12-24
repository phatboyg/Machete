namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class TryGetValueTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_get_entity_of_repeatable_field()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN~60044^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select new {MSH = msh, PID = pid });

            Assert.IsNotNull(result.Result);
            Assert.IsTrue(result.Select(x => x.PID).Select(x => x.PatientIdentifierList).TryGetValue(0, out Value<CX> id));
            Assert.AreEqual("60043", id.Select(x => x.IdNumber).ValueOrDefault());
            Assert.AreEqual("MACHETE", id.Select(x => x.AssigningAuthority).Select(x => x.NamespaceId).ValueOrDefault());
            Assert.AreEqual("MRN", id.Select(x => x.IdentifierTypeCode).ValueOrDefault());
        }

        [Test]
        public void Should_throw_ValueMissingException_exception_trying_to_access_out_of_range_data()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN~60044^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select new {MSH = msh, PID = pid });

            Assert.IsNotNull(result.Result);
            Assert.IsFalse(result.Select(x => x.PID).Select(x => x.PatientIdentifierList).TryGetValue(5, out Value<CX> id));
            
            Assert.Throws<ValueMissingException>(() =>
            {
                string idNumber = id.Select(x => x.IdNumber).Value;
            });
        }

        [Test]
        public void Should_throw_SliceMissingException_exception_trying_to_access_empty_field()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select new {MSH = msh, PID = pid });

            Assert.IsNotNull(result.Result);

            Assert.Throws<SliceMissingException>(() =>
            {
                bool foundValue = result.Select(x => x.PID).Select(x => x.PatientIdentifierList).TryGetValue(0, out Value<CX> id);
                string idNumber = id.Select(x => x.IdNumber).Value;
            });
        }
    }
}