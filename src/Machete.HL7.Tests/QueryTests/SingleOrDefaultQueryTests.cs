namespace Machete.HL7.Tests.QueryTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class SingleOrDefaultQueryTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Test()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
VL1|a~b~c";
            
            var parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from pid in q.Select<PIDSegment>()
                from vls in q.Select<ValueListSegment>().ZeroOrMore().SingleOrDefault()
                select vls);

            Assert.IsTrue(result.HasResult);
            
            int count = result.Select(x => x.RepeatedString).Count();
            
            Assert.AreEqual(3, count);
        }
    }
}