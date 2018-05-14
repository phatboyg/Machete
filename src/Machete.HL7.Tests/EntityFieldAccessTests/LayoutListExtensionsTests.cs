namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class LayoutListExtensionsTests :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public void Should_return_enumerator()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
ORC|CA|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
ORC|NA|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<TestLayoutOptionalOrders, HL7Entity> layout));

            IParser<HL7Entity, TestLayoutOptionalOrders> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, TestLayoutOptionalOrders> result = parse.Query(query);

            IEnumerable<Layout<Order>> notes = result.Select(x => x.Orders).ToEnumerable();
            
            Assert.IsTrue(result.HasResult);
            Assert.AreEqual(3, notes.Count());
            Assert.AreEqual("NW", notes.ElementAt(0).Select(x => x.ORC).Select(x => x.OrderControl).ValueOrDefault());
            Assert.AreEqual("CA", notes.ElementAt(1).Select(x => x.ORC).Select(x => x.OrderControl).ValueOrDefault());
            Assert.AreEqual("NA", notes.ElementAt(2).Select(x => x.ORC).Select(x => x.OrderControl).ValueOrDefault());
        }
        
        [Test]
        public void Should_work_with_empty_list()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<TestLayoutOptionalOrders, HL7Entity> layout));

            IParser<HL7Entity, TestLayoutOptionalOrders> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));

            Result<Cursor<HL7Entity>, TestLayoutOptionalOrders> result = parse.Query(query);

            IEnumerable<Layout<Order>> notes = result.Select(x => x.Orders).ToEnumerable();
            
            Assert.IsTrue(result.HasResult);
            Assert.AreEqual(0, notes.Count());
        }
    }
}