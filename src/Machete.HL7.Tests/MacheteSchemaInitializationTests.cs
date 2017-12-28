namespace Machete.HL7.Tests
{
    using System;
    using System.Diagnostics;
    using HL7Schema.V26;
    using NUnit.Framework;


    [TestFixture]
    public class MacheteSchemaInitializationTests
    {
        [Test]
        public void HL7SchemaInitializationTest()
        {
            Stopwatch sw1 = new Stopwatch();

            sw1.Start();
            var schema = Schema.Factory.CreateHL7<HL7Entity>(cfg => cfg.AddFromNamespaceContaining<MSH>());
            sw1.Stop();

            TimeSpan time1 = sw1.Elapsed;
            Console.WriteLine("Schema Initialization: 00:00:{0:00}.{1:00}", time1.Seconds, time1.Milliseconds / 10);

            Stopwatch sw2 = new Stopwatch();

            sw2.Start();
            var parser = Parser.Factory.CreateHL7(schema);
            sw2.Stop();

            TimeSpan time2 = sw2.Elapsed;
            Console.WriteLine("Parser Initialization: 00:00:{0:00}.{1:00}", time2.Seconds, time2.Milliseconds / 10);
            
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2351||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2352||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa";

            ParseResult<HL7Entity> parse = parser.Parse(message);

            var result = parse.Query(q =>
            {
                var obxQuery = from obx in q.Select<OBX>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    select new
                    {
                        OBX = obx,
                        NTE = nte
                    };

                var obrQuery = from obr in q.Select<OBR>()
                    from dg1 in q.Select<DG1>()
                    from obx in obxQuery.ZeroOrMore()
                    from pon in obr.PlacerOrderNumber from ponv in pon.EntityIdentifier
                    from usi in obr.UniversalServiceIdentifier from usiv in usi.Identifier
                    select new
                    {
                        OBR = obr,
                        OBX = obx,
                        DG1 = dg1,

                        PlacerOrderNumber = ponv,
                        UniversalServiceIdentifier = usiv
                    };

                var orderQuery = from orc in q.Select<ORC>()
                    from obr in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        Tests = obr
                    };

                return from msh in q.Select<MSH>()
                    from pid in q.Select<PID>()
                    from orders in orderQuery.ZeroOrMore()
                    select new
                    {
                        MSH = msh,
                        PID = pid,
                        Orders = orders
                    };
            });

            Stopwatch sw3 = new Stopwatch();
            
            sw3.Start();
            string placerOrderNumber1 = result.Result.Orders[0].Tests[0].PlacerOrderNumber;
            sw3.Stop();

            TimeSpan time3 = sw3.Elapsed;
            Console.WriteLine("Query Run 1: 00:00:{0:00}.{1:00}", time3.Seconds, time3.Milliseconds);

            Stopwatch sw4 = new Stopwatch();
            
            sw4.Start();
            string placerOrderNumber2 = result.Result.Orders[0].Tests[0].PlacerOrderNumber;
            sw4.Stop();
            
            TimeSpan time4 = sw4.Elapsed;
            Console.WriteLine("Query Run 2: 00:00:{0:00}.{1:00}", time4.Seconds, time4.Milliseconds);
        }
    }
}