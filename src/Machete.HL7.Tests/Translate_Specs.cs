﻿namespace Machete.HL7.Tests
{
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Segments;
    using Testing;


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

            Assert.That(result.HasValue, Is.True);

            Assert.IsTrue(result.Select(x => x.SendingApplication).HasValue);
            Assert.That(result.Select(x => x.SendingApplication).Value, Is.EqualTo("MACHETELAB"));

            Assert.IsTrue(result.Select(x => x.ReceivingApplication).HasValue);
            Assert.That(result.Select(x => x.ReceivingApplication).Value, Is.EqualTo("UBERMED"));

            var translator = Schema.GetEntityTranslator(typeof(EmptyEntityTranslate), () => new EmptyEntityTranslate());

            var translateResult = await translator.Translate(entityResult, result);

            MSHSegment translated;
            Assert.IsTrue(translateResult.TryGetEntity(0, out translated));
            Assert.That(translated.SendingApplication, Is.Not.Null);
            Assert.IsTrue(translated.SendingApplication.HasValue);
            Assert.That(translated.SendingApplication.ValueOrDefault(), Is.EqualTo("MACHETELAB"));
            Assert.IsTrue(translated.ReceivingApplication.HasValue);
            Assert.That(translated.ReceivingApplication.ValueOrDefault(), Is.EqualTo("MACHETELAB"));
            Assert.AreEqual(
                translated.ReceivingApplication.ValueOrDefault(),
                translated.SendingApplication.ValueOrDefault());
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

            Assert.That(result.HasValue, Is.True);

            var translator = Schema.GetEntityTranslator(typeof(EmptyPidEntityTranslate), () => new EmptyPidEntityTranslate());

            var translateResult = await translator.Translate(entityResult, result);

            PIDSegment translated;
            Assert.IsTrue(translateResult.TryGetEntity(0, out translated));
            Assert.That(translated.PatientIdentifierList.HasValue, Is.True);
            Assert.That(translated.PatientIdentifierList[0].HasValue, Is.True);
            Assert.IsTrue(translated.PatientIdentifierList[0].Select(x => x.IdNumber).HasValue);
            Assert.That(translated.PatientIdentifierList[0].Select(x => x.IdNumber).ValueOrDefault(), Is.EqualTo("60043"));
        }


        class EmptyEntityTranslate :
            HL7TranslateEntityMap<MSHSegment, MSHSegment, HL7Entity>
        {
            public EmptyEntityTranslate()
            {
                Copy(x => x.ReceivingApplication, x => x.SendingApplication);
            }
        }


        class EmptyObxEntityTranslate :
            HL7TranslateEntityMap<OBXSegment, OBXSegment, HL7Entity>
        {
        }


        class EmptyPidEntityTranslate :
            HL7TranslateEntityMap<PIDSegment, PIDSegment, HL7Entity>
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

            var translator = Schema.CreateTranslator(typeof(MessageTranslation), () => new MessageTranslation());

            var translateResult = await translator.Translate(entityResult);

            var result = translateResult.Query(q =>
                from msh in q.Select<MSHSegment>()
                from pid in q.Select<PIDSegment>()
                select new {msh, pid});

            Assert.That(result.HasValue, Is.True);

            Assert.That(result.Value.pid.PatientIdentifierList.HasValue, Is.True);

            Assert.That(result.Value.pid.PatientIdentifierList[0].HasValue, Is.True);

            var id = result.Value.pid.PatientIdentifierList[0];

            Assert.IsTrue(id.Select(x => x.IdNumber).HasValue);
            Assert.That(id.Select(x => x.IdNumber).ValueOrDefault(), Is.EqualTo("60043"));

            Assert.IsTrue(result.Value.msh.ReceivingApplication.HasValue);
            Assert.That(result.Value.msh.ReceivingApplication.Value, Is.EqualTo("MACHETELAB"));
        }


        class MessageTranslation :
            TranslateMap<HL7Entity>
        {
            public MessageTranslation()
            {
                Translate<MSHSegment>(x => x.Using<ReplaceSendingApplication>());
                Translate<PIDSegment>(x => x.Using<LowerCaseContent>());
            }
        }


        class ReplaceSendingApplication :
            HL7TranslateEntityMap<MSHSegment, MSHSegment, HL7Entity>
        {
            public ReplaceSendingApplication()
            {
                Copy(x => x.ReceivingApplication, x => x.SendingApplication);
            }
        }


        class LowerCaseContent :
            HL7TranslateEntityMap<PIDSegment, PIDSegment, HL7Entity>
        {
            public LowerCaseContent()
            {
            }
        }


        class EmptyPidEntityTranslate :
            HL7TranslateEntityMap<PIDSegment, PIDSegment, HL7Entity>
        {
            public EmptyPidEntityTranslate()
            {
            }
        }
    }
}