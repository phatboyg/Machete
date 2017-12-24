namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class EscapeCharacterTests :
        HL7MacheteTestHarness<ParserTestSegment, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_parse_subcomponent_escape_sequence()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PTS|Johnson \T\ Johnson|";

            var parsed = Parser.Parse(message);
            var result = parsed.Query(q => from msh in q.Select<MSHSegment>()
                from pts in q.Select<ParserTestSegment>() from st in pts.StandardText
                select st);

            string standardText = result.ValueOrDefault();
            
            Assert.AreEqual("Johnson \\T\\ Johnson", standardText);
        }

        [Test]
        public void Should_be_able_to_parse_field_separator_escape_sequence()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PTS|Johnson \F\ Johnson|";

            var parsed = Parser.Parse(message);
            var result = parsed.Query(q => from msh in q.Select<MSHSegment>()
                from pts in q.Select<ParserTestSegment>().Select(x => x.StandardText)
                select pts);

            string standardText = result.ValueOrDefault();
            
            Assert.AreEqual("Johnson \\F\\ Johnson", standardText);
        }

        [Test]
        public void Should_be_able_to_parse_component_separator_escape_sequence()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PTS|Johnson \S\ Johnson|";

            var parsed = Parser.Parse(message);
            var result = parsed.Query(q => from msh in q.Select<MSHSegment>()
                from pts in q.Select<ParserTestSegment>()
                select pts);

            string standardText = result.Select(x => x.StandardText).ValueOrDefault();
            
            Assert.AreEqual("Johnson \\S\\ Johnson", standardText);
        }

        [Test]
        public void Should_be_able_to_parse_escape_separator_escape_sequence()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PTS|Johnson \E\ Johnson|";

            var parsed = Parser.Parse(message);
            var result = parsed.Query(q => from msh in q.Select<MSHSegment>()
                from pts in q.Select<ParserTestSegment>()
                select pts);

            string standardText = result.Select(x => x.StandardText).ValueOrDefault();
            
            Assert.AreEqual("Johnson \\E\\ Johnson", standardText);
        }

        [Test]
        public void Should_be_able_to_parse_highlight_escape_sequence()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PTS|Johnson \H\ Johnson|";

            var parsed = Parser.Parse(message);
            var result = parsed.Query(q => from msh in q.Select<MSHSegment>()
                from pts in q.Select<ParserTestSegment>()
                select pts);

            string standardText = result.Select(x => x.StandardText).ValueOrDefault();
            
            Assert.AreEqual("Johnson \\H\\ Johnson", standardText);
        }

        [Test]
        public void Should_be_able_to_parse_repetition_separator_escape_sequence()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PTS|Johnson \R\ Johnson|";

            var parsed = Parser.Parse(message);
            var result = parsed.Query(q => from msh in q.Select<MSHSegment>()
                from pts in q.Select<ParserTestSegment>()
                select pts);

            string standardText = result.Select(x => x.StandardText).ValueOrDefault();
            
            Assert.AreEqual("Johnson \\R\\ Johnson", standardText);
        }
    }
}