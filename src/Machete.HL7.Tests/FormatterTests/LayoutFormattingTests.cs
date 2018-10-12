﻿namespace Machete.HL7.Tests.FormatterTests
{
    using System;
    using Machete.Formatters;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class LayoutFormattingTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test, Ignore("Will not run successful until issue #39 is fixed")]
        public void Should_be_able_to_format_layout()
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

            EntityResult<HL7Entity> parse = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<O01Event, HL7Entity> layout));

            IParser<HL7Entity, O01Event> query = parse.CreateQuery(q => layout.CreateParser(LayoutParserOptions.None, q));
            Result<Cursor<HL7Entity>, O01Event> result = parse.Query(query);
            
            Assert.That(result.HasResult, Is.True);

            LayoutList<TestSchema.ORM_O01_ORDER> orders = result.Select(x => x.Orders);

            Assert.That(Schema.TryGetLayoutFormatter(out ILayoutFormatter<TestSchema.ORM_O01_ORDER> formatter), Is.True);

//            var formatted = await Formatter.FormatToStringAsync(result);
            var context = new StringBuilderFormatContext();

            formatter.Format(context, orders[0].Value);
            
            Console.WriteLine(context.ToString());

            Assert.That(context.ToString(), Is.EqualTo(message));
        }
    }
}