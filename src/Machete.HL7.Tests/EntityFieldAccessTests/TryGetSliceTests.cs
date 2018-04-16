namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class TryGetSliceTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_access_entity_fields()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);

            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsTrue(result.Result.ParsedText.TryGetSlice(8, out var slice));
            Assert.AreEqual("ORM^O01", slice.Text.ToString());
        }
        
        [Test]
        public void Should_be_able_to_get_repeating_fields()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN~60044^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select pid);

            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsTrue(result.Result.ParsedText.TryGetSlice(3, out var slice));
            Assert.AreEqual("60043^^^MACHETE^MRN~60044^^^MACHETE^MRN", slice.Text.ToString());
        }
        
        [Test]
        public void Should_not_throw_when_no_fields_on_empty_entity()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select pid);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsFalse(result.Result.ParsedText.TryGetSlice(1, out var slice));
            Assert.AreEqual(Slice.Missing, slice);
            Assert.IsFalse(slice.TryGetSlice(2, out _));
        }

        [Test]
        public void Should_be_able_to_get_field_using_Select_syntax()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                select msh);

            Assert.IsNotNull(result.Result);
            Assert.IsTrue(result.Result.ParsedText.TryGetSlice(8, out TextSlice slice));
            Assert.AreEqual("ORM^O01", slice.Text.ToString());
        }
        
        [Test]
        public void Should_be_able_to_get_component_of_complex_field_from_entity_text_slice()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
NTE|1||KOPASD
NTE|2||A3RJ
NTE|3||7ADS
NTE|4||G46DG
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
PD1|M|F|N||||F|
NTE|1||IN42
PV1|1|O|||||92383^Machete^Janice||||||||||||12345|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||MACHETE INC|1234 Fruitvale ave^^Oakland^CA^94601^USA||5101234567^^^^^510^1234567|074394|||||||A1|MACHETE^JOE||19890909|123 SEASAME STREET^^Oakland^CA^94600||||||||||||N|||||666889999|0||||||F||||T||60043^^^MACHETE^MRN
GT1|1|60043^^^MACHETE^MRN|MACHETE^JOE||123 SEASAME STREET^^Oakland^CA^94600|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(parse.TryGetEntity(5, out HL7Segment segment));
            Assert.IsTrue(segment is PID);
            Assert.IsTrue(segment.ParsedText.TryGetSlice(3, out var slice));
            Assert.AreEqual("60043^^^MACHETE^MRN", slice.Text.ToString());
            Assert.IsTrue(slice.TryGetSlice(3, out var componentSlice));
            Assert.AreEqual("MACHETE", componentSlice.Text.ToString());
        }
        
        [Test]
        public void Should_not_throw_trying_to_get_component_text_slice_having_negative_index()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
NTE|1||KOPASD
NTE|2||A3RJ
NTE|3||7ADS
NTE|4||G46DG
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
PD1|M|F|N||||F|
NTE|1||IN42
PV1|1|O|||||92383^Machete^Janice||||||||||||12345|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||MACHETE INC|1234 Fruitvale ave^^Oakland^CA^94601^USA||5101234567^^^^^510^1234567|074394|||||||A1|MACHETE^JOE||19890909|123 SEASAME STREET^^Oakland^CA^94600||||||||||||N|||||666889999|0||||||F||||T||60043^^^MACHETE^MRN
GT1|1|60043^^^MACHETE^MRN|MACHETE^JOE||123 SEASAME STREET^^Oakland^CA^94600|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(parse.TryGetEntity(5, out HL7Segment segment));
            Assert.IsTrue(segment is PID);
            Assert.IsTrue(segment.ParsedText.TryGetSlice(3, out var slice));
            Assert.AreEqual("60043^^^MACHETE^MRN", slice.Text.ToString());
            Assert.IsFalse(slice.TryGetSlice(-1, out _));
        }
    }
}