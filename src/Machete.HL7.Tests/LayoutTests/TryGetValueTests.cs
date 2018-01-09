namespace Machete.HL7.Tests.LayoutTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class TryGetValueTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_get_segment_from_list_using_SegmentList()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<OrderLayout, HL7Entity> layout));

            IParser<HL7Entity, OrderLayout> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, OrderLayout> result = parse.Query(query);
            
            Assert.That(result.HasResult, Is.True);
            
            var segments = result.Select(x => x.Notes);
            
            Assert.That(segments.HasValue, Is.True);
            Assert.AreEqual(3, segments.Count());
            Assert.IsTrue(segments.TryGetValue(1, out Segment<NTESegment> segment));
            Assert.AreEqual("y", segment.Select(x => x.SourceOfComment).ValueOrDefault());
        }

        [Test]
        public void Should_not_be_able_to_get_segment_from_list_with_negative_index()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<OrderLayout, HL7Entity> layout));

            IParser<HL7Entity, OrderLayout> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, OrderLayout> result = parse.Query(query);
            
            Assert.That(result.HasResult, Is.True);
            
            var segments = result.Select(x => x.Notes);
            
            Assert.That(segments.HasValue, Is.True);
            Assert.AreEqual(3, segments.Count());
            Assert.IsFalse(segments.TryGetValue(-1, out Segment<NTESegment> segment));
        }

        [Test]
        public void Should_throw_SegmentOutOfRangeException_when_trying_to_access_segment_from_list_with_negative_index()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<OrderLayout, HL7Entity> layout));

            IParser<HL7Entity, OrderLayout> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, OrderLayout> result = parse.Query(query);
            
            Assert.That(result.HasResult, Is.True);
            
            var segments = result.Select(x => x.Notes);
            
            Assert.That(segments.HasValue, Is.True);
            Assert.AreEqual(3, segments.Count());

            Assert.Throws<SegmentOutOfRangeException>(() =>
            {
                Assert.IsFalse(segments.TryGetValue(-1, out Segment<NTESegment> segment));

                NTESegment note = segment.Value;
            });
        }

        [Test]
        public void Should_not_be_able_to_get_segment_from_list_with_out_of_bounds_index()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<OrderLayout, HL7Entity> layout));

            IParser<HL7Entity, OrderLayout> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, OrderLayout> result = parse.Query(query);
            
            Assert.That(result.HasResult, Is.True);
            
            var segments = result.Select(x => x.Notes);
            
            Assert.That(segments.HasValue, Is.True);
            Assert.AreEqual(3, segments.Count());
            Assert.IsFalse(segments.TryGetValue(100, out Segment<NTESegment> segment));
        }
    }
}