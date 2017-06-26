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

            ParsedResult<HL7Entity> parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
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
                       from pid in q.Select<PID>().ZeroOrMore()
                    from ignored in q.Except<HL7Segment, ORC>().ZeroOrMore()
                    from orders in testQuery.ZeroOrMore()
                    select new
                    {
                        MSH = msh,
                        Orders = orders
                    };
            });

            Assert.That(result.HasValue, Is.True);

            var orderedTests = result.Value.Orders;
            
            Assert.AreEqual(3, orderedTests.Count);
            //Assert.That(result.Value.Orders, Is.Not.Empty);

            foreach (var order in orderedTests)
            {
                var placerGroupNumber = order.ORC.PlacerGroupNumber.ValueOrDefault();
                Console.WriteLine(placerGroupNumber);
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

            ParsedResult<HL7Entity> parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
            {
                var obxQuery = from obx in q.Select<OBR>()
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

            ParsedResult<HL7Entity> parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
            {
                var obxQuery = from obx in q.Select<OBR>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    select new
                    {
                        OBX = obx,
                        NTE = nte
                    };

                var obrQuery = from obr in q.Select<OBR>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    from ctd in q.Select<CTD>()
                    // .ZeroOrOne()
                    from obx in obxQuery.ZeroOrMore()
                    from dg1 in q.Select<DG1>().ZeroOrMore()
                    select new
                    {
                        OBR = obr,
                        NTE = nte,
                        CTD = ctd,
                        OBX = obx,
                        DG1 = dg1
                    };

                var testQuery = from orc in q.Select<ORC>().SkipUntil(q.Select<ORC>())
                    from obr in obrQuery.ZeroOrMore()
                    from ft1 in q.Select<FT1>().ZeroOrMore()
                    from cti in q.Select<CTI>().ZeroOrMore()
                    from blg in q.Select<BLG>()
                    // .ZeroOrOne()
                    //from unknown in q.Select<HL7Segment>().Where(x => x.SegmentId.HasValue && x.SegmentId != "ORC")
                    select new
                    {
                        ORC = orc,
                        Tests = obr,
                        CTI = cti,
                        BLG = blg
                        //Unknown = unknown
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
            //Assert.That(result.Value.Orders, Is.Not.Empty);

            foreach (var order in result.Value.Orders)
            {
                //    var placerOrderNumber1 = order.Tests[0].OBR.PlacerOrderNumber;
                //    var placerOrderNumber2 = order.Tests[1].OBR.PlacerOrderNumber;
                //    var catalogId1 = order.Tests[0].OBR.UniversalServiceIdentifier;
                //    var catalogId2 = order.Tests[1].OBR.UniversalServiceIdentifier;

                //    Assert.IsTrue(placerOrderNumber1.HasValue);
                //    Assert.IsTrue(placerOrderNumber2.HasValue);
                //    Assert.AreEqual("PRO2350", placerOrderNumber1.Value);
                //    Assert.AreEqual("PRO2351", placerOrderNumber2.Value);
                //    Assert.IsTrue(catalogId1.Value.Identifier.HasValue);
                //    Assert.IsTrue(catalogId2.Value.Identifier.HasValue);
                //    Assert.AreEqual("11636", catalogId1.Value.Identifier.Value);
                //    Assert.AreEqual("11637", catalogId2.Value.Identifier.Value);
                //}
            }
        }
    }
}