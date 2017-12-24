namespace Machete.HL7.Tests.LayoutTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class Using_a_template :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_possible()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            Assert.That(Schema.TryGetLayout(out ILayoutParserFactory<MessageLayout, HL7Entity> layout), Is.True);

            IParser<HL7Entity, MessageLayout> query = entityResult.CreateQuery(layout);

            Result<Cursor<HL7Entity>, MessageLayout> result = entityResult.Query(query);
            
            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Select(x => x.MSH), Is.Not.Null);
            Assert.That(result.Select(x => x.MSH).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN), Is.Not.Null);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).HasValue, Is.False);
        }

        [Test]
        public void Should_pull_the_optional_segments_without_a_glitch()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            Assert.That(Schema.TryGetLayout(out ILayoutParserFactory<MessageLayout, HL7Entity> layout), Is.True);

            IParser<HL7Entity, MessageLayout> query = entityResult.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, MessageLayout> result = entityResult.Query(query);

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Select(x => x.MSH), Is.Not.Null);
            Assert.That(result.Select(x => x.MSH).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN), Is.Not.Null);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).Select(x => x.SegmentId).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).Select(x => x.RecordedDateTime).HasValue, Is.True);
        }

        [Test]
        public void Should_use_a_much_cleaner_syntax()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            Result<Cursor<HL7Entity>, MessageLayout> result = Parser.Parse(message).Query(x => x.Layout<MessageLayout>());
            
            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Select(x => x.MSH), Is.Not.Null);
            Assert.That(result.Select(x => x.MSH).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN), Is.Not.Null);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).Select(x => x.SegmentId).HasValue, Is.True);
            Assert.That(result.Select(x => x.Optional).Select(x => x.EVN).Select(x => x.RecordedDateTime).HasValue, Is.True);
        }
        
        [Test]
        public void Should_be_able_to_query_order_tests()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc";

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<OrderLayout, HL7Entity> layout));

            IParser<HL7Entity, OrderLayout> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, OrderLayout> result = parse.Query(query);
            
            Assert.That(result.HasResult, Is.True);
            
            string placerOrderNumber = result
                .Select(x => x.ORC)
                .Select(x => x.PlacerOrderNumber)
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();
            
            Assert.AreEqual("PRO2352", placerOrderNumber);
        }
    }
}