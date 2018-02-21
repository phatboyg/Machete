namespace Machete.HL7.Tests.FormatterTests
{
    using System.Threading.Tasks;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class SimpleQueryFormattingTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public async Task Test()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q => from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from orc in q.Select<ORC>()
                from obr in q.Select<OBR>()
                select new
                {
                    MSH = msh,
                    PID = pid,
                    ORC = orc,
                    OBR = obr
                });
            
//            var formatted = await Formatter.FormatToStringAsync()
        }
    }
}