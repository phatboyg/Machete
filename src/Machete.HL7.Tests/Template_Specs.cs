namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;


    [TestFixture]
    public class Using_a_template :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_possible()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            ILayoutParserFactory<MessageLayout, HL7Entity> layout;
            Assert.That(Schema.TryGetLayout(out layout), Is.True);

            Parser<HL7Entity, MessageLayout> query = entityResult.CreateQuery(layout);

            Result<Cursor<HL7Entity>, MessageLayout> result = entityResult.Query(query);

            Assert.That(result.HasValue, Is.True);

            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.IsPresent, Is.True);

            Assert.That(result.Value.Optional.IsPresent, Is.True);

            Assert.That(result.Value.Optional.Value.EVN, Is.Not.Null);
            Assert.That(result.Value.Optional.Value.EVN.IsPresent, Is.False);
        }

        [Test]
        public void Should_pull_the_optional_segments_without_a_glitch()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            ILayoutParserFactory<MessageLayout, HL7Entity> layout;
            Assert.That(Schema.TryGetLayout(out layout), Is.True);

            Parser<HL7Entity, MessageLayout> query = entityResult.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, MessageLayout> result = entityResult.Query(query);

            Assert.That(result.HasValue, Is.True);

            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.IsPresent, Is.True);

            Assert.That(result.Value.Optional.IsPresent, Is.True);

            Assert.That(result.Value.Optional.Value.EVN, Is.Not.Null);
            Assert.That(result.Value.Optional.Value.EVN.IsPresent, Is.True);
            Assert.That(result.Value.Optional.Value.EVN.HasValue, Is.True);
            Assert.That(result.Value.Optional.Value.EVN.Value.SegmentId.HasValue, Is.True);
            Assert.That(result.Value.Optional.Value.EVN.Value.RecordedDateTime.HasValue, Is.True);
        }

        [Test]
        public void Should_use_a_much_cleaner_syntax()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            Result<Cursor<HL7Entity>, MessageLayout> result = Parser.Parse(message).Query(x => x.Layout<MessageLayout>());

            Assert.That(result.HasValue, Is.True);

            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.IsPresent, Is.True);

            Assert.That(result.Value.Optional.IsPresent, Is.True);

            Assert.That(result.Value.Optional.Value.EVN, Is.Not.Null);
            Assert.That(result.Value.Optional.Value.EVN.IsPresent, Is.True);
            Assert.That(result.Value.Optional.Value.EVN.HasValue, Is.True);
            Assert.That(result.Value.Optional.Value.EVN.Value.SegmentId.HasValue, Is.True);
            Assert.That(result.Value.Optional.Value.EVN.Value.RecordedDateTime.HasValue, Is.True);
        }
    }
}