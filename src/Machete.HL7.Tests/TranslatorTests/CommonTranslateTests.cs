namespace Machete.HL7.Tests.TranslatorTests
{
    using System;
    using System.Threading.Tasks;
    using Machete.TranslatorConfiguration;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class CommonTranslateTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public async Task Should_support_value_list_properties()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026^^^KNIFE1|60043^^^MACHETE1^MRN~60044^^^MACHETE2^MRN~60045^^^MACHETE3^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var engine = Schema.GetTranslator<MessageTranslation>();

            var translateResult = await engine.Translate(entityResult);

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
    }
}