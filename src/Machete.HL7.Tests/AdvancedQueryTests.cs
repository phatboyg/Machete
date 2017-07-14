namespace Machete.HL7.Tests
{
    using System;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class AdvancedQueryTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test, Explicit("Not passing")]
        public void Should_be_able_to_query_blocks()
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
                    from dg1 in q.Select<DG1>().Optional()
                    from obx in obxQuery.Optional()
                    select new
                    {
                        OBR = obr,
                        DG1 = dg1,
                        OBX = obx
                    };

                var testQuery = from orc in q.Select<ORC>()
                    from obr in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        Tests = obr
                    };

                return from msh in q.Select<MSH>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    from pid in q.Select<PID>()
                    from ignored in q.Except<HL7Segment, ORC>().ZeroOrMore()
                    from orders in testQuery.ZeroOrMore()
                    select new
                    {
                        MSH = msh,
                        Ignored = ignored,
                        Orders = orders
                    };
            });

            Assert.That(result.HasValue, Is.True);

            Assert.That(result.Value.Ignored.Count, Is.EqualTo(7));

            var orderedTests = result.Value.Orders;

            Assert.AreEqual(3, orderedTests.Count);
            //Assert.That(result.Value.Orders, Is.Not.Empty);

            foreach (var order in orderedTests)
            {
                var placerGroupNumber = order.ORC.PlacerGroupNumber;
                var universalId = placerGroupNumber.Select(x => x.UniversalId);
                Assert.IsTrue(universalId.HasValue);
                Assert.AreEqual("XO934N", universalId.Value);

                for (int i = 0; i < order.Tests.Count; i++)
                {
                    string placerOrderNumber = order.Tests[i].OBR.PlacerOrderNumber.Select(x => x.UniversalId).ValueOrDefault();
                    var catalogId = order.Tests[i].OBR.UniversalServiceIdentifier.ValueOrDefault();

                    Assert.AreEqual($"PRO235{i}", placerOrderNumber);
                    Assert.AreEqual($"1163{i}", catalogId.Identifier.ValueOrDefault());
                }
            }
        }

        [Test, Explicit("Not Passing")]
        public void Should_be_able_to_query_blocks_conditionally()
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
                    from nte in q.Select<NTE>().ZeroOrMore()
                    from obx in obxQuery.ZeroOrMore()
                    from dg1 in q.Select<DG1>().ZeroOrMore()
                    let placerOrderNumber = obr.PlacerOrderNumber
                    where placerOrderNumber.Value.UniversalId.IsEqualTo("PRO2350")
                    select new
                    {
                        OBR = obr,
                        NTE = nte,
                        OBX = obx,
                        DG1 = dg1
                    };

                var testQuery = from orc in q.Select<ORC>().SkipUntil(q.Select<ORC>())
                    from test in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        Tests = test
                    };

                return from msh in q.Select<MSH>()
                    from orders in testQuery.ZeroOrMore()
                    select new
                    {
                        MSH = msh,
                        Orders = orders
                    };
            });

            Assert.That(result.HasValue, Is.True);
            Assert.AreEqual(1, result.Value.Orders);

            foreach (var order in result.Value.Orders)
            {
                var placerGroupNumber = order.ORC.PlacerGroupNumber.ValueOrDefault();
                Assert.AreEqual("XO934N", placerGroupNumber.UniversalId);

                for (int i = 0; i < order.Tests.Count; i++)
                {
                    string placerOrderNumber = order.Tests[i].OBR.PlacerOrderNumber.Value.UniversalId.ValueOrDefault();
                    var catalogId = order.Tests[i].OBR.UniversalServiceIdentifier.ValueOrDefault();

                    Assert.AreEqual($"PRO235{i}", placerOrderNumber);
                    Assert.AreEqual($"1163{i}", catalogId.Identifier.ValueOrDefault());
                }
            }
        }

        [Test]
        public void Should_be_able_to_query_complex_blocks()
        {
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

            ParseResult<HL7Entity> parse = Parser.Parse(message);

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
                        UniversalServiceIdentifier = usiv,
                    };

                var orderQuery = from orc in q.Select<ORC>()
                    from obr in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        Tests = obr,
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

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.Orders, Is.Not.Null);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.PID, Is.Not.Null);
            Assert.That(result.Value.Orders.Count, Is.EqualTo(3));

            Assert.That(result.Value.Orders[0].Tests[0].PlacerOrderNumber, Is.EqualTo("PRO2350"));
            Assert.That(result.Value.Orders[1].Tests[0].PlacerOrderNumber, Is.EqualTo("PRO2351"));
            Assert.That(result.Value.Orders[2].Tests[0].PlacerOrderNumber, Is.EqualTo("PRO2352"));

            Assert.That(result.Value.Orders[0].Tests[0].UniversalServiceIdentifier, Is.EqualTo("11636"));
            Assert.That(result.Value.Orders[1].Tests[0].UniversalServiceIdentifier, Is.EqualTo("11637"));
            Assert.That(result.Value.Orders[2].Tests[0].UniversalServiceIdentifier, Is.EqualTo("11638"));
        }

        [Test]
        public void Should_be_able_to_query_nested_blocks()
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
                    OBR = obr,
                });

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.PID, Is.Not.Null);
        }
    }
}