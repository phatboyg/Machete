namespace Machete.HL7.Tests
{
    using NUnit.Framework;
    using Segments;
    using Testing;


    [TestFixture]
    public class SegmentListTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_query_order_tests_segment_list()
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
            Assert.That(result.Select(x => x.Notes).HasValue, Is.True);
            
            var sourceOfComment = result.Select(x => x.Notes)[1].Select(x => x.SourceOfComment).ValueOrDefault();
            
            Assert.AreEqual("y", sourceOfComment);
        }

        [Test]
        public void Should_be_able_to_count_SegmentList()
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
            Assert.That(result.Select(x => x.Notes).HasValue, Is.True);
            Assert.AreEqual(3, result.Select(x => x.Notes).Count());
        }
    }
}