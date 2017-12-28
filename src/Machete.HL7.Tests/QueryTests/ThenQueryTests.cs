namespace Machete.HL7.Tests.QueryTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class ThenQueryTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test, Explicit("I think the query is bad")]
        public void Should_be_able_to_skip_middle_segments_via_Except()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
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
                from msh in q.Select<MSH>()
                from orc in q.Select<HL7Segment>().Then(q.Select<ORC>()).ZeroOrMore()
                select orc);

            Assert.That(query.HasResult, Is.True);

            var tests = query.Result;
            
            Assert.AreEqual(3, tests.Count);

            foreach (var test in tests)
            {
                string placerGroupNumber = test.PlacerGroupNumber.Select(x => x.EntityIdentifier).ValueOrDefault();
                
                Assert.AreEqual("XO934N", placerGroupNumber);
            }
        }

    }
}