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

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            ILayout<MessageLayout, HL7Entity> layout;
            Assert.That(Structure.TryGetLayout(out layout), Is.True);

            Parser<HL7Entity, MessageLayout> query = parsed.CreateQuery(q => layout.CreateQuery(TemplateQueryOptions.None, q));

            Result<Cursor<HL7Entity>, MessageLayout> result = parsed.Query(query);

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

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            ILayout<MessageLayout, HL7Entity> layout;
            Assert.That(Structure.TryGetLayout(out layout), Is.True);

            Parser<HL7Entity, MessageLayout> query = parsed.CreateQuery(q => layout.CreateQuery(TemplateQueryOptions.None, q));

            Result<Cursor<HL7Entity>, MessageLayout> result = parsed.Query(query);

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