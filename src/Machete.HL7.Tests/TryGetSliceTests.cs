namespace Machete.HL7.Tests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class TryGetSliceTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_get_source_complex_field_text()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|^^^^^^^abc|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from orc in q.Select<ORC>()
                from obr in q.Select<OBR>()
                select new
                {
                    MSH = msh,
                    PID = pid,
                    ORC = orc,
                    OBR = obr
                });

            result.Select(x => x.PID).Select(x => x.PatientId).Slice.TryGetSlice(2, out TextSlice slice);
            string dateTimeOffset = slice.Text.ToString();
            
            Assert.IsNotNull(slice);
            Assert.AreEqual("^^^^^^^abc", dateTimeOffset);
        }

        [Test]
        public void Should_not_blow_up_trying_to_get_source_of_empty_complex_field_text()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from orc in q.Select<ORC>()
                from obr in q.Select<OBR>()
                select new
                {
                    MSH = msh,
                    PID = pid,
                    ORC = orc,
                    OBR = obr
                });

            result.Select(x => x.PID).Select(x => x.PatientId).Slice.TryGetSlice(2, out TextSlice slice);
            string dateTimeOffset = slice.Text.ToString();
            
            Assert.IsNotNull(slice);
            Assert.IsEmpty(dateTimeOffset);
        }

        [Test]
        public void Should_be_able_to_get_source_complex_text()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|a^b^c^d^e^f^g^abc^e|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from orc in q.Select<ORC>()
                from obr in q.Select<OBR>()
                select new
                {
                    MSH = msh,
                    PID = pid,
                    ORC = orc,
                    OBR = obr
                });

            result.Select(x => x.PID).Select(x => x.PatientId).Select(x => x.ExpirationDate).Slice.TryGetSlice(7, out TextSlice slice);
            string dateTimeOffset = slice.Text.ToString();
            
            Assert.IsNotNull(slice);
            Assert.IsNotEmpty(dateTimeOffset);
            Assert.AreEqual("abc", dateTimeOffset);
        }
    }
}