namespace Machete.HL7.Tests.TranslatorTests
{
    using System;
    using System.Threading.Tasks;
    using HL7Schema.V26;
    using Machete.TranslatorConfiguration;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class TranslateObserverTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public async Task Should_support_value_list_properties()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026^^^KNIFE1|60043^^^MACHETE1^MRN~60044^^^MACHETE2^MRN~60045^^^MACHETE3^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);

            var engine = Schema.GetTranslator<MessageTranslation>();

            var translateResult = await engine.Translate(entityResult);

            ITranslatorObserver<HL7Entity> observer = new TranslatorObserver();
            ObserverHandle connectTranslatorObserver = engine.ConnectTranslatorObserver(observer);
            var result = translateResult.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                select new {msh, pid});

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Result.pid.PatientIdentifierList.HasValue, Is.True);
            Assert.That(result.Result.pid.PatientIdentifierList[0].HasValue, Is.True);

            var id = result.Result.pid.PatientIdentifierList[0];

            Assert.IsTrue(id.Select(x => x.IdNumber).HasValue);
            Assert.That(id.Select(x => x.IdNumber).ValueOrDefault(), Is.EqualTo("60043"));
            Assert.IsTrue(result.Result.msh.ReceivingApplication.HasValue);
            Assert.AreEqual("MACHETELAB", result.Select(x => x.msh).Select(x => x.ReceivingApplication).Select(x => x.NamespaceId).ValueOrDefault());
            Assert.IsTrue(result.Result.msh.MessageType.HasValue);

            var messageType = result.Select(x => x.msh).Select(x => x.MessageType);
            
            Assert.IsTrue(messageType.Select(x => x.MessageCode).IsEqualTo("ADT"));
            Assert.IsTrue(messageType.Select(x => x.TriggerEvent).IsEqualTo("A04"));
        }


        class TranslatorObserver :
            ITranslatorObserver<HL7Entity>
        {
            public async Task PreTranslateEntity<TEntity, TInput>(TEntity entity, TranslateContext<TInput, HL7Entity> context)
            {
                throw new NotImplementedException();
            }

            public async Task PostTranslateEntity<TInput>(TranslateResult<HL7Entity> result, TranslateContext<TInput, HL7Entity> context)
            {
                throw new NotImplementedException();
            }

            public async Task PreCreateEntity<TEntity>(TEntity entity, TranslateContext<HL7Entity> context)
            {
                throw new NotImplementedException();
            }

            public async Task PostCreateEntity(TranslateResult<HL7Entity> result, TranslateContext<HL7Entity> context)
            {
                throw new NotImplementedException();
            }
        }


        class MessageTranslation :
            HL7Translation<HL7Entity>
        {
            public MessageTranslation()
            {
                Translate<MSH>(x => x.Using<ReplaceSendingApplication>());
                Translate<PID>(x => x.Using<LowerCaseContent>());
            }
        }


        class ReplaceSendingApplication :
            HL7SegmentTranslation<MSH, HL7Entity>
        {
            public ReplaceSendingApplication()
            {
                Copy(x => x.ReceivingApplication, x => x.SendingApplication);
                Set(x => x.DateTimeOfMessage, x => DateTimeOffset.UtcNow);
                Set(x => x.MessageType, x => x.Using<ReplaceMessageType>());
            }
        }


        class ReplaceMessageType :
            HL7ComponentCreation<HL7Schema.V26.MSG, HL7Entity>
        {
            public ReplaceMessageType()
            {
                Set(x => x.MessageCode, x => x.Value("ADT"));
                Set(x => x.TriggerEvent, x => x.Value("A04"));
            }
        }


        class LowerCaseContent :
            HL7SegmentTranslation<PID, HL7Entity>
        {
            public LowerCaseContent()
            {
                Translate(x => x.PatientId, x => x.By(cfg => { cfg.Set(m => m.CheckDigitScheme, context => Value.Constant("27")); }));
            }
        }
    }
}