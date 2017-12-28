namespace Machete.HL7.Tests.TranslatorTests
{
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class PreserveOrderTranslateTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public async Task Should_properly_order_the_segment_ids()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORU^R01|1999077678|P|2.3|||AL|AL
PID|1|000000000026^^^KNIFE1|60043^^^MACHETE1^MRN~60044^^^MACHETE2^MRN~60045^^^MACHETE3^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
OBR|1|H421|H421
OBX|1|ST|CYSCFR^CF Results^CYSCFR|1|
OBX|3|ST|CYSCFR^CF Results^CYSCFR|2|
OBR|1|H421|H421
OBX|2|ST|CYSCFR^CF Results^CYSCFR|1|
OBX|3|ST|CYSCFR^CF Results^CYSCFR|2|
OBX|4|ST|CYSCFR^CF Results^CYSCFR|3|
OBX|9|ST|CYSCFR^CF Results^CYSCFR|4|";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var translator = Schema.GetTranslator<ResultTranslation>();

            var result = await translator.Translate(entityResult);

            Assert.That(result.HasResult, Is.True);

            Assert.That(result.TryGetEntity(2, out OBRSegment obr1), Is.True);
            Assert.That(obr1.SetId.Value, Is.EqualTo(1));

            Assert.That(result.TryGetEntity(3, out OBXSegment obx11), Is.True);
            Assert.That(obx11.SetId.Value, Is.EqualTo(1));

            Assert.That(result.TryGetEntity(4, out OBXSegment obx12), Is.True);
            Assert.That(obx12.SetId.Value, Is.EqualTo(2));

            Assert.That(result.TryGetEntity(5, out OBRSegment obr2), Is.True);
            Assert.That(obr2.SetId.Value, Is.EqualTo(2));

            Assert.That(result.TryGetEntity(6, out OBXSegment obx21), Is.True);
            Assert.That(obx21.SetId.Value, Is.EqualTo(1));

            Assert.That(result.TryGetEntity(7, out OBXSegment obx22), Is.True);
            Assert.That(obx22.SetId.Value, Is.EqualTo(2));

            Assert.That(result.TryGetEntity(8, out OBXSegment obx23), Is.True);
            Assert.That(obx23.SetId.Value, Is.EqualTo(3));

            Assert.That(result.TryGetEntity(9, out OBXSegment obx24), Is.True);
            Assert.That(obx24.SetId.Value, Is.EqualTo(4));
        }


        class ResultTranslation :
            HL7Translation<HL7Entity>
        {
            public ResultTranslation()
            {
                Translate<OBRSegment>(x => x.Using<RenumberObrSegments>());
                Translate<OBXSegment>(x => x.Using<RenumberObxSegments>());
            }
        }


        class RenumberObrSegments :
            HL7SegmentTranslation<OBRSegment, HL7Entity>
        {
            public RenumberObrSegments()
            {
                Set(x => x.SetId, context => context.NextSequenceNumber<OBRSegment>());
            }
        }


        class RenumberObxSegments :
            HL7SegmentTranslation<OBXSegment, HL7Entity>
        {
            public RenumberObxSegments()
            {
                Set(x => x.SetId, context => context.NextSequenceNumber<OBRSegment, OBXSegment>());
            }
        }
    }
}