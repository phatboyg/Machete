namespace Machete.HL7.Tests
{
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Segments;
    using Testing;


    [TestFixture]
    public class Formatting_an_HL7_segment :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test, Explicit]
        public async Task Should_return_the_same_as_the_input()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var formatted = await Formatter.FormatToStringAsync(entityResult);

            Assert.That(formatted.Text, Is.EqualTo(message));
        }

        [Test]
        public async Task Should_return_the_same_as_the_input_without_required()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ADT^A04|K113|P";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var formatted = await Formatter.FormatToStringAsync(entityResult);

            Assert.That(formatted.Text, Is.EqualTo(message));
        }

        [Test]
        public async Task Should_format_a_really_big_message()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN
ORC|NW|PRO2350||XO934N
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var formatted = await Formatter.FormatToStringAsync(entityResult);

            Assert.That(formatted.Text, Is.EqualTo(message.Replace("\n", "\r")));
        }

        [Test]
        public async Task Should_simply_format_using_entity_formatter()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = await Formatter.FormatToStringAsync(entityResult);

            Assert.That(result.Text, Is.EqualTo(message));
        }
    }
}