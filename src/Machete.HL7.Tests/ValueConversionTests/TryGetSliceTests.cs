namespace Machete.HL7.Tests.ValueConversionTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class TryGetSliceTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_access_entity_fields()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);

            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsTrue(result.Result.ParsedText.TryGetSlice(8, out var slice));
            Assert.AreEqual("ORM^O01", slice.Text.ToString());
        }
        
        [Test]
        public void Should_be_able_to_get_fields()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN~60044^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select pid);

            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsTrue(result.Result.ParsedText.TryGetSlice(3, out var slice));
            Assert.AreEqual("60043^^^MACHETE^MRN~60044^^^MACHETE^MRN", slice.Text.ToString());
        }
        
        [Test]
        public void Should_be_able_return_no_fields_on_empty_entity()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select pid);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsFalse(result.Result.ParsedText.TryGetSlice(1, out var slice));
            Assert.AreEqual(Slice.Missing, slice);
        }

        [Test]
        public void Should_be_able_to_get_field_using_Select_syntax()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                select new {MSH = msh });

            Assert.IsNotNull(result.Result);
            Assert.IsTrue(result.Select(x => x.MSH).Result.ParsedText.TryGetSlice(8, out TextSlice slice));
            Assert.AreEqual("ORM^O01", slice.Text.ToString());
        }
    }
}