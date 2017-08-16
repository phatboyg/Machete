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
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var formatted = await Formatter.FormatToStringAsync(entityResult);

            Assert.That(formatted.Text, Is.EqualTo(message));
        }

        [Test]
        public async Task Should_return_the_same_as_the_input_without_required()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var formatted = await Formatter.FormatToStringAsync(entityResult);

            Assert.That(formatted.Text, Is.EqualTo(message));
        }

        [Test]
        public void Should_simply_format_using_entity_formatter()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            MSHSegment entity;
            Assert.That(entityResult.TryGetEntity(0, out entity), Is.True);

            IEntityFormatter<MSHSegment> formatter;
            Assert.That(Schema.TryGetEntityFormatter(out formatter), Is.True);

            var context = new StringBuilderFormatContext();

            formatter.Format(context, entity);

            Assert.That(context.ToString(), Is.EqualTo(message));
        }
    }
}