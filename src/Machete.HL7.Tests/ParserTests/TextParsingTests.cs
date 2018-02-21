namespace Machete.HL7.Tests.ParserTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;
    using Texts;


    [TestFixture]
    public class TextParsingTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_use_the_factory_specified()
        {
            var schema = Machete.Schema.Factory.CreateHL7<HL7Entity>();
        }

        [Test]
        public void Should_parse_the_opening_segment()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            var result = Parser.Parse(text, new TextSpan(0, text.Length));
        }

        [Test]
        public void Should_throw_exception_when_there_are_too_many_parsing_delimiters()
        {
            const string message = @"MSH|^~\ &|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            Assert.Throws<MacheteParserException>(() =>
            {
                var result = Parser.Parse(text, new TextSpan(0, text.Length));
            });
        }

        [Test]
        public void Should_throw_exception_when_parsing_delimiters_are_missing()
        {
            const string message = @"MSH||LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            Assert.Throws<MacheteParserException>(() =>
            {
                var result = Parser.Parse(text, new TextSpan(0, text.Length));
            });
        }

        [Test]
        public void Should_throw_exception_when_parsing_delimiters_are_alphanumeric()
        {
            const string message = @"MSH|AB12|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            Assert.Throws<MacheteParserException>(() =>
            {
                var result = Parser.Parse(text, new TextSpan(0, text.Length));
            });
        }

        [Test]
        public void Should_return_false_on_an_empty_message()
        {
            const string message = @"";

            var result = Parser.Parse(message);

            Assert.That(result.HasResult, Is.False);
            Assert.That(result.RemainingSpan.Length, Is.EqualTo(0));
            Assert.That(result.RemainingSpan.Start, Is.EqualTo(0));
        }
        
        [Test]
        public void Should_properly_show_the_span_was_consumed_with_no_message()
        {
            const string message = "    ";

            var result = Parser.Parse(message);

            Assert.That(result.HasResult, Is.False);
            Assert.That(result.RemainingSpan.Length, Is.EqualTo(0));
            Assert.That(result.RemainingSpan.Start, Is.EqualTo(4));
        }
        
        [Test]
        public void Should_properly_show_the_span_was_consumed_with_no_message_and_blank_lines()
        {
            const string message = "    \n";

            var result = Parser.Parse(message);

            Assert.That(result.HasResult, Is.False);
            Assert.That(result.RemainingSpan.Length, Is.EqualTo(0));
            Assert.That(result.RemainingSpan.Start, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_able_to_handle_leading_whitespace_on_MSH()
        {
            const string message = @"    MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
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

            Assert.IsTrue(result.HasResult);
            Assert.AreEqual("ORM", result.Select(x => x.MSH).Select(x => x.MessageType).Select(x => x.MessageCode).ValueOrDefault());
        }

        [Test]
        public void Should_throw_exception_if_MSH_not_first()
        {
            const string message = @"PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

            Assert.Throws<MacheteParserException>(() =>
            {
                ParseResult<HL7Entity> parse = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_MSH_missing()
        {
            const string message = @"PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

            Assert.Throws<MacheteParserException>(() =>
            {
                ParseResult<HL7Entity> parse = Parser.Parse(message);
            });
        }
    }
}