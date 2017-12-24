namespace Machete.HL7.Tests.TranslatorTests
{
    using System;
    using System.Threading.Tasks;
    using Machete.TranslatorConfiguration;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class Using_an_empty_translate :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public async Task Should_simply_match_the_input()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                select msh);

            Assert.That(result.HasResult, Is.True);

            Assert.IsTrue(result.Select(x => x.SendingApplication).HasValue);
            Assert.That(result.Select(x => x.SendingApplication).Value, Is.EqualTo("MACHETELAB"));

            Assert.IsTrue(result.Select(x => x.ReceivingApplication).HasValue);
            Assert.That(result.Select(x => x.ReceivingApplication).Value, Is.EqualTo("UBERMED"));

            var translator = Schema.GetEntityTranslator<MSHSegment, MSHSegment, EmptyEntityTranslate>();

            var translateResult = await translator.Translate(entityResult, result);

            Assert.IsTrue(translateResult.TryGetEntity(0, out MSHSegment translated));
            Assert.IsFalse(translated.ParsedText.TryGetSlice(0, out var _));
            Assert.That(translated.SendingApplication, Is.Not.Null);
            Assert.IsTrue(translated.SendingApplication.HasValue);
            Assert.That(translated.SendingApplication.ValueOrDefault(), Is.EqualTo("MACHETELAB"));
            Assert.IsTrue(translated.ReceivingApplication.HasValue);
            Assert.That(translated.ReceivingApplication.ValueOrDefault(), Is.EqualTo("MACHETELAB"));
            Assert.AreEqual(translated.ReceivingApplication.ValueOrDefault(), translated.SendingApplication.ValueOrDefault());
        }

        [Test]
        public async Task Should_support_value_list_properties()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026^^^KNIFE1|60043^^^MACHETE1^MRN~60044^^^MACHETE2^MRN~60045^^^MACHETE3^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var result = entityResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from pid in q.Select<PIDSegment>()
                select pid);

            Assert.That(result.HasResult, Is.True);

            var translator = Schema.GetEntityTranslator<PIDSegment, PIDSegment, EmptyPidEntityTranslate>();

            var translateResult = await translator.Translate(entityResult, result);

            Assert.IsTrue(translateResult.TryGetEntity(0, out PIDSegment translated));
            Assert.That(translated.PatientIdentifierList.HasValue, Is.True);
            Assert.That(translated.PatientIdentifierList[0].HasValue, Is.True);
            Assert.IsTrue(translated.PatientIdentifierList[0].Select(x => x.IdNumber).HasValue);
            Assert.That(translated.PatientIdentifierList[0].Select(x => x.IdNumber).ValueOrDefault(), Is.EqualTo("60043"));
        }


        class EmptyEntityTranslate :
            HL7SegmentTranslation<MSHSegment, HL7Entity>
        {
            public EmptyEntityTranslate()
            {
                Copy(x => x.ReceivingApplication, x => x.SendingApplication);
            }
        }


        class EmptyObxEntityTranslate :
            HL7SegmentTranslation<OBXSegment, HL7Entity>
        {
        }


        class EmptyPidEntityTranslate :
            HL7SegmentTranslation<PIDSegment, HL7Entity>
        {
        }
    }


    [TestFixture]
    public class Using_a_regular_translate :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public async Task Should_support_value_list_properties()
        {
            const string message =
                @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026^^^KNIFE1|60043^^^MACHETE1^MRN~60044^^^MACHETE2^MRN~60045^^^MACHETE3^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var translator = Schema.GetTranslator<MessageTranslation>();

            var translateResult = await translator.Translate(entityResult);

            var result = translateResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from pid in q.Select<PIDSegment>()
                select new {msh, pid});

            Assert.That(result.HasResult, Is.True);

            Assert.That(result.Result.pid.PatientIdentifierList.HasValue, Is.True);

            Assert.That(result.Result.pid.PatientIdentifierList[0].HasValue, Is.True);

            var id = result.Result.pid.PatientIdentifierList[0];

            Assert.IsTrue(id.Select(x => x.IdNumber).HasValue);
            Assert.That(id.Select(x => x.IdNumber).ValueOrDefault(), Is.EqualTo("60043"));

            Assert.IsTrue(result.Result.msh.ReceivingApplication.HasValue);
            Assert.That(result.Result.msh.ReceivingApplication.Value, Is.EqualTo("MACHETELAB"));

            Assert.IsTrue(result.Result.msh.MessageType.HasValue);

            var messageType = result.Select(x => x.msh).Select(x => x.MessageType);
            Assert.IsTrue(messageType.Select(x => x.MessageCode).IsEqualTo("ADT"));
            Assert.IsTrue(messageType.Select(x => x.TriggerEvent).IsEqualTo("A04"));
        }

        [Test]
        public async Task Should_display_definition()
        {
            var translator = Schema.GetTranslator<MessageTranslation>();

            var definition = translator.ToString();

            Console.WriteLine(definition);
        }


        class MessageTranslation :
            HL7Translation<HL7Entity>
        {
            public MessageTranslation()
            {
                Translate<MSHSegment>(x => x.Using<ReplaceSendingApplication>());
                Translate<PIDSegment>(x => x.Using<LowerCaseContent>());
            }
        }


        class ReplaceSendingApplication :
            HL7SegmentTranslation<MSHSegment, HL7Entity>
        {
            public ReplaceSendingApplication()
            {
                Copy(x => x.ReceivingApplication, x => x.SendingApplication);

                Set(x => x.CreationDateTime, x => DateTimeOffset.UtcNow);

                Set(x => x.MessageType, x => x.Using<ReplaceMessageType>());
            }
        }


        class ReplaceMessageType :
            HL7ComponentCreation<MSG, HL7Entity>
        {
            public ReplaceMessageType()
            {
                Set(x => x.MessageCode, x => x.Value("ADT"));
                Set(x => x.TriggerEvent, x => x.Value("A04"));
            }
        }


        class LowerCaseContent :
            HL7SegmentTranslation<PIDSegment, HL7Entity>
        {
            public LowerCaseContent()
            {
                Translate(x => x.PatientId, x => x.By(cfg => { cfg.Set(m => m.CheckDigitScheme, context => Value.Constant("27")); }));
            }
        }


        class EmptyPidEntityTranslate :
            HL7SegmentTranslation<PIDSegment, HL7Entity>
        {
            public EmptyPidEntityTranslate()
            {
            }
        }
    }


    [TestFixture]
    public class TranslateSetId_Specs :
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