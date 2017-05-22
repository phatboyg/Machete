﻿namespace Machete.HL7.Tests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Segments;
    using Testing;
    using HL7Entity = HL7.HL7Entity;


    [TestFixture]
    public class Querying_a_schema :
        MacheteHL7TestContext<MSHSegment>
    {
        [Test]
        public void Should_be_possible()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
        }

        [Test]
        public void Should_not_blow_up()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from x in q.Select<MSHSegment>()
                select x);

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
        }

        [Test]
        public void Should_throw_ValueMissingException()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var query = Query<HL7Entity>.Create(q =>
                from x in q.Select<MSHSegment>()
                select new {x.MessageType});

            var result = parsed.Query(query);

            Assert.That(result.HasValue, Is.True);
            Assert.Throws<ValueMissingException>(() =>
            {
                string messageCode = result.Value.MessageType.Value.MessageCode.Value;
            });
        }

        [Test]
        public void Should_parse_a_series_of_segments()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|A08|201701131234|||12901";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Value.EVN, Is.Not.Null);
        }

        [Test]
        public void Should_parse_a_series_of_segments_using_optional()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var mshSegmentQuery = parsed.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>().FirstOrDefault()
                select new {MSH = msh, EVN = evn});

            var result = parsed.Query(mshSegmentQuery);

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MSH, Is.Not.Null);
            Assert.That(result.Value.MSH.MessageType.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.HasValue, Is.True);
            Assert.That(result.Value.MSH.MessageType.Value.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.That(result.Value.EVN, Is.Null);
        }

        [Test]
        public void Should_parse_a_series_of_segments_but_not_match()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from evn in q.Select<EVNSegment>()
                select new {MSH = msh, EVN = evn});

            Assert.That(result.HasValue, Is.False);
        }

        [Test]
        public void Should_parse_a_segment_and_parse_into_the_component()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            Parsed<HL7Entity> parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from mt in msh.MessageType
                from mc in mt.MessageCode
                from te in mt.TriggerEvent
                where mc == "ORU"
                select new {MSH = msh, MT = mt, MC = mc, TE = te});

            Assert.That(result.HasValue, Is.True);
            Assert.That(result.Value.MC, Is.EqualTo("ORU"));
            Assert.That(result.Value.TE, Is.EqualTo("R01"));
        }

        [Test]
        public void Should_be_able_to_conditionally_parse()
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
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|90^Wetteland^Jennifer||14994^Elliott-Mullens^Danette^Rai
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||14994^Elliott-Mullens^Danette^Rai|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa";

            Parsed<HL7.HL7Entity> parsed = Parser.Parse(message);

            var query = Query<HL7.HL7Entity>.Create(q =>
            {
                return from msh in q.Select<MSH>()
                    from obr in q.Select<OBR>().Where(x => x.PlacerOrderNumber.HasValue && x.PlacerOrderNumber.Value.UniversalId.IsEqualTo("PRO2350")).ZeroOrMore()
                    select new
                    {
                        MSH = msh,
                        Tests = obr
                    };
            });

            var result = parsed.Query(query);

            Assert.That(result.HasValue, Is.True);

        }
    }
}