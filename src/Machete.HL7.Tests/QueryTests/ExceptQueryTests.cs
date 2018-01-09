namespace Machete.HL7.Tests.QueryTests
{
    using System.Collections.Generic;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class ExceptQueryTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_skip_top_segments_via_Except()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2351||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
            {
                var obxQuery = from obx in q.Select<OBX>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    select new
                    {
                        OBX = obx,
                        NTE = nte
                    };

                var obrQuery = from obr in q.Select<OBR>()
                    from dg1 in q.Select<DG1>().Optional()
                    from obx in obxQuery.Optional()
                    select new
                    {
                        OBR = obr,
                        DG1 = dg1,
                        Observation = obx
                    };

                var testQuery = from orc in q.Select<ORC>()
                    from obr in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        Request = obr
                    };

                return from ignored in q.Except<HL7Segment, ORC>().ZeroOrMore()
                    from tests in testQuery.ZeroOrMore()
                    select new
                    {
                        Ignored = ignored,
                        NotIgnored = tests
                    };
            });

            Assert.That(query.HasResult, Is.True);

            IReadOnlyList<HL7Segment> ignoredSegments = query.Result.Ignored;
            
            Assert.IsTrue(ignoredSegments[0] is MSH);
            Assert.IsTrue(ignoredSegments[1] is PID);

            var notIgnored = query.Result.NotIgnored;

            foreach (var segment in notIgnored)
            {
                var orcSegments = segment.Request;
                
                Assert.IsNotNull(orcSegments);
                Assert.IsNotEmpty(orcSegments);
                Assert.IsTrue(orcSegments[0].OBR.EntityInfo.EntityType == typeof(OBR));
                Assert.IsTrue(orcSegments[0].DG1.EntityInfo.EntityType == typeof(DG1));
                Assert.IsTrue(orcSegments[0].Observation.OBX.EntityInfo.EntityType == typeof(OBX));
                Assert.IsTrue(orcSegments[0].Observation.NTE[0].EntityInfo.EntityType == typeof(NTE));
                Assert.IsTrue(orcSegments[0].Observation.NTE[1].EntityInfo.EntityType == typeof(NTE));
            }
        }

        [Test]
        public void Should_be_able_to_skip_middle_segments_via_Except()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
NTE|1||KOPASD
NTE|2||A3RJ
NTE|3||7ADS
NTE|4||G46DG
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
PD1|M|F|N||||F|
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
NTE|2||dsa";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
            {
                var obxQuery = from obx in q.Select<OBX>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    select new
                    {
                        OBX = obx,
                        NTE = nte
                    };

                var obrQuery = from obr in q.Select<OBR>()
                    from dg1 in q.Select<DG1>().Optional()
                    from obx in obxQuery.Optional()
                    select new
                    {
                        OBR = obr,
                        DG1 = dg1,
                        Observation = obx
                    };

                var testQuery = from orc in q.Select<ORC>()
                    from obr in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        Request = obr
                    };

                return from msh in q.Select<MSH>()
                    from notes in q.Select<NTE>().ZeroOrMore()
                    from pid in q.Select<PID>()
                    from ignored in q.Except<HL7Segment, ORC>().ZeroOrMore()
                    from tests in testQuery.ZeroOrMore()
                    select new
                    {
                        MSH = msh,
                        Notes = notes,
                        PID = pid,
                        Ignored = ignored,
                        Tests = tests
                    };
            });

            Assert.That(query.HasResult, Is.True);

            IReadOnlyList<HL7Segment> ignoredSegments = query.Result.Ignored;
            
            Assert.IsTrue(ignoredSegments[0] is PD1);
            Assert.IsTrue(ignoredSegments[1] is PV1);
            Assert.IsTrue(ignoredSegments[2] is PV2);
            Assert.IsTrue(ignoredSegments[3] is IN1);
            Assert.IsTrue(ignoredSegments[4] is GT1);
            Assert.IsTrue(ignoredSegments[5] is AL1);

            foreach (var test in query.Result.Tests)
            {
                var orcSegments = test.Request;
                
                Assert.IsNotNull(orcSegments);
                Assert.IsNotEmpty(orcSegments);
                Assert.IsTrue(orcSegments[0].OBR.EntityInfo.EntityType == typeof(OBR));
                Assert.IsTrue(orcSegments[0].DG1.EntityInfo.EntityType == typeof(DG1));
                Assert.IsTrue(orcSegments[0].Observation.OBX.EntityInfo.EntityType == typeof(OBX));
                Assert.IsTrue(orcSegments[0].Observation.NTE[0].EntityInfo.EntityType == typeof(NTE));
                Assert.IsTrue(orcSegments[0].Observation.NTE[1].EntityInfo.EntityType == typeof(NTE));
            }
        }
    }
}