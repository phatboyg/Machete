namespace Machete.HL7.Tests
{
    using HL7Schema;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class AdvancedQueryTests :
        MacheteHL7TestContext<Version26>
    {
        [Test]
        public void Should_be_able_to_query_blocks()
        {
            const string message = @"MSH|^~\&|NextGen|^DOSC|RH|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
NTE|1||KOPASD
NTE|2||A3RJ
NTE|3||7ADS
NTE|4||G46DG
PID|1|000000000026|60043^^^NextGen^MRN||RELAY^SIX||19890909|F|||156 STREET^^Bend^OR^97701^^^^DESCHUTES||5416666666|5418888888||||||||||||||||N
PD1|M|F|N||||F|
NTE|1||IN42
PV1|1|O|||||14994^Elliott-Mullens^Danette^Rai||||||||||||25064|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||EBMS|PO Box 21367^^Billings^MT^59104||8007773575^^^^^800^0777357|0000917|||||||C1|RELAY^SIX||19890909|156 STREET^^Bend^OR^97701||||||||||||N|||||666889999|0||||||F||||T||60043^^^NextGen^MRN
GT1|1|60043^^^NextGen^MRN|RELAY^SIX||156 STREET^^Bend^OR^97701^^^^DESCHUTES|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|90^Wetteland^Jennifer||14994^Elliott-Mullens^Danette^Rai
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|90^Wetteland^Jennifer||14994^Elliott-Mullens^Danette^Rai
OBR|1|PRO2351||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|90^Wetteland^Jennifer||14994^Elliott-Mullens^Danette^Rai
OBR|1|PRO2352||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa";

            Parsed<HL7.HL7Entity> parsed = Parser.Parse(message);

            var query = Query<HL7.HL7Entity>.Create(q =>
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
                    select new
                    {
                        OBR = obr,
                        NTE = nte,
                        OBX = obx,
                        DG1 = dg1
                    };

                var testQuery = from orc in q.Select<ORC>().SkipUntil(q.Select<ORC>())
                    from obr in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        Tests = obr
                    };

                return from msh in q.Select<MSH>()
                    from orders in testQuery.ZeroOrMore()
                    select new
                    {
                        MSH = msh,
                        Orders = orders
                    };
            });

            var result = parsed.Query(query);

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

        [Test]
        public void Should_be_able_to_query_complex_blocks()
        {
            const string message = @"MSH|^~\&|NextGen|^DOSC|RH|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
NTE|1||KOPASD
NTE|2||A3RJ
NTE|3||7ADS
NTE|4||G46DG
PID|1|000000000026|60043^^^NextGen^MRN||RELAY^SIX||19890909|F|||156 STREET^^Bend^OR^97701^^^^DESCHUTES||5416666666|5418888888||||||||||||||||N
PD1|M|F|N||||F|
NTE|1||IN42
PV1|1|O|||||14994^Elliott-Mullens^Danette^Rai||||||||||||25064|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||EBMS|PO Box 21367^^Billings^MT^59104||8007773575^^^^^800^0777357|0000917|||||||C1|RELAY^SIX||19890909|156 STREET^^Bend^OR^97701||||||||||||N|||||666889999|0||||||F||||T||60043^^^NextGen^MRN
GT1|1|60043^^^NextGen^MRN|RELAY^SIX||156 STREET^^Bend^OR^97701^^^^DESCHUTES|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|90^Wetteland^Jennifer||14994^Elliott-Mullens^Danette^Rai
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|90^Wetteland^Jennifer||14994^Elliott-Mullens^Danette^Rai
OBR|1|PRO2351||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|90^Wetteland^Jennifer||14994^Elliott-Mullens^Danette^Rai
OBR|1|PRO2352||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa";

            Parsed<HL7.HL7Entity> parsed = Parser.Parse(message);

            var query = Query<HL7.HL7Entity>.Create(q =>
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

            var result = parsed.Query(query);

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