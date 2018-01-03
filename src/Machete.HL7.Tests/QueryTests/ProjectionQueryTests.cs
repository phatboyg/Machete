namespace Machete.HL7.Tests.QueryTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ProjectionQueryTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Should_be_possible()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                select msh);

            var query = entityResult.Query(mshSegmentQuery);

            Assert.That(query.HasResult, Is.True);
        }

        [Test]
        public void Should_throw_ValueMissingException()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                select new {MSH = msh});

            var query = entityResult.Query(mshQuery);

            Assert.That(query.HasResult, Is.True);
            
            Assert.Throws<ValueEmptyException>(() =>
            {
                string messageCode = query.Result.MSH.MessageType.Value.MessageCode.Value;
            });
        }

        [Test]
        public void Should_throw_ValueEmptyException()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                select new {msh.MessageType, MSH = msh});

            var query = entityResult.Query(mshQuery);

            Assert.That(query.HasResult, Is.True);
            
            Assert.Throws<ValueEmptyException>(() =>
            {
                string messageCode = query.Result.MessageType.Value.MessageCode.Value;
            });
        }

        [Test]
        public void Should_parse_a_series_of_segments()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            var query = entityResult.Query(mshSegmentQuery);

            Assert.That(query.HasResult, Is.True);
            Assert.That(query.Result.MSH, Is.Not.Null);
            Assert.That(query.Result.MSH.MessageType.HasValue, Is.True);
            Assert.That(query.Result.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(query.Result.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(query.Result.EVN, Is.Not.Null);
        }
//
//        [Test]
//        public void Should_be_able_to_skip_segments_via_selection()
//        {
//            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
//EVN|A08|201701131234|||12901";
//
//            EntityResult<HL7Entity> entityResult = Parser.Parse(message);
//
//            var query = entityResult.Query(q =>
//                from ignored in q.Except<HL7Segment, EVNSegment>().ZeroOrMore()
//                from segment in q.Select<EVNSegment>()
//                where segment.EntityInfo.IsDefined
//                select new {segment, ignored});
//
//            Assert.That(query.HasResult, Is.True);
//            Assert.That(query.Result.segment.SegmentId, Is.Not.Null);
//            Assert.That(query.Result.segment.SegmentId.HasValue, Is.True);
//            Assert.That(query.Result.segment.SegmentId.Value, Is.EqualTo("EVN"));
//            Assert.That(query.Result.ignored.Count, Is.EqualTo(1));
//            Assert.That(query.Result.ignored[0].SegmentId.Value, Is.EqualTo("MSH"));
//        }

        [Test]
        public void Should_parse_a_series_of_segments_using_optional()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>().Optional()
                select new {MSH = msh, EVN = evn});

            var query = entityResult.Query(mshSegmentQuery);

            Assert.That(query.HasResult, Is.True);
            Assert.That(query.Result.MSH, Is.Not.Null);
            Assert.That(query.Result.MSH.MessageType.HasValue, Is.True);
            Assert.That(query.Result.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(query.Result.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(query.Result.EVN, Is.Null);
        }

        [Test]
        public void Should_parse_a_series_of_segments_but_not_match()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            Assert.That(query.HasResult, Is.False);
        }

        [Test]
        public void Should_parse_a_segment_and_parse_into_the_component()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});

            Assert.That(query.HasResult, Is.True);
            Assert.That(query.Result.MC, Is.EqualTo("ORU"));
            Assert.That(query.Result.TE, Is.EqualTo("R01"));
        }

        [Test]
        public void Should_be_able_to_parse_first_segment_of_list()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
NTE|1|KOPASD
NTE|2|A3RJ
NTE|3|7ADS
NTE|4|G46DG
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
PD1|M|F|N||||F|
NTE|1|IN42
PV1|1|O|||||92383^Machete^Janice||||||||||||12345|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||MACHETE INC|1234 Fruitvale ave^^Oakland^CA^94601^USA||5101234567^^^^^510^1234567|074394|||||||A1|MACHETE^JOE||19890909|123 SEASAME STREET^^Oakland^CA^94600||||||||||||N|||||666889999|0||||||F||||T||60043^^^MACHETE^MRN
GT1|1|60043^^^MACHETE^MRN|MACHETE^JOE||123 SEASAME STREET^^Oakland^CA^94600|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|abc
NTE|2|dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|abc
NTE|2|dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|abc
NTE|2|dsa";

            var entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from nte in q.Select<NTESegment>().ZeroOrMore().FirstOrDefault()
                from skip in q.Except<HL7Segment, HL7Segment>().ZeroOrMore()
                select nte);
            
            Assert.IsTrue(query.HasResult);
            Assert.AreEqual("KOPASD", query.Result.SourceOfComment.ValueOrDefault());
        }

        [Test]
        public void Should_be_able_to_return_single_segment_as_list()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
NTE|1|KOPASD
NTE|2|A3RJ
NTE|3|7ADS
NTE|4|G46DG
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
PD1|M|F|N||||F|
NTE|1|IN42
PV1|1|O|||||92383^Machete^Janice||||||||||||12345|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||MACHETE INC|1234 Fruitvale ave^^Oakland^CA^94601^USA||5101234567^^^^^510^1234567|074394|||||||A1|MACHETE^JOE||19890909|123 SEASAME STREET^^Oakland^CA^94600||||||||||||N|||||666889999|0||||||F||||T||60043^^^MACHETE^MRN
GT1|1|60043^^^MACHETE^MRN|MACHETE^JOE||123 SEASAME STREET^^Oakland^CA^94600|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|abc
NTE|2|dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|abc
NTE|2|dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|abc
NTE|2|dsa";

            var entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from notes in q.Select<NTESegment>().ZeroOrMore()
                from pid in q.Select<PIDSegment>().One()
                from skip in q.Except<HL7Segment, HL7Segment>().ZeroOrMore()
                select pid);
            
            Assert.IsTrue(query.HasResult);
            
            Value<CXComponent> patientId = query.Result[0].PatientIdentifierList[0];
            
            Assert.IsTrue(patientId.HasValue);
            Assert.IsTrue(patientId.IsPresent);
            Assert.AreEqual("60043", patientId.Select(x => x.IdNumber).ValueOrDefault());
            Assert.AreEqual("MACHETE", patientId.Select(x => x.AssigningAuthority).Select(x => x.NamespaceId).ValueOrDefault());
            Assert.AreEqual("MRN", patientId.Select(x => x.IdentifierTypeCode).ValueOrDefault());
        }
    }
}