namespace Machete.HL7.Tests.TranslatorTests
{
    using System;
    using System.Threading.Tasks;
    using Contexts;
    using HL7Schema.V26;
    using Machete.Translators.Results;
    using Machete.Translators.TranslateContexts;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class NewTranslateTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public async Task Should_support_value_list_properties()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);
            var translator = Schema.CreateEntityTranslator<PIDSegment, PIDTranslate>();
            var creator = Schema.CreateTranslator<MessageTranslation>();
//            var translateResult = await translator.Translate();
            var translateResult2 = await translator.Translate(entityResult);

            Assert.IsTrue(translateResult2.TryGetEntity(0, out MSHSegment translated));

            var formatter = await Formatter.FormatToStringAsync(translateResult2);
            Console.WriteLine(formatter.Text);
            Assert.IsTrue(translated.SegmentId.HasValue);
//            Assert.IsTrue(translated.MessageType.HasValue);
            Console.WriteLine(translated.MessageType.Value.MessageCode.ValueOrDefault());
            Assert.AreEqual("ORM", translated.MessageType.Value.MessageCode.ValueOrDefault());
            Assert.AreEqual("O01", translated.MessageType.Value.TriggerEvent.ValueOrDefault());
        }


//        public class FakeContext<TSchema> :
//            TranslateContext<TSchema>
//            where TSchema : Entity
//        {
//            public bool HasContext(Type contextType) => false;
//
//            public bool TryGetContext<T>(out T context)
//                where T : class =>
//                throw new NotImplementedException();
//
//            public T GetOrAddContext<T>(ContextFactory<T> contextFactory)
//                where T : class =>
//                throw new NotImplementedException();
//
//            public T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
//                where T : class =>
//                throw new NotImplementedException();
//
//            public IReadOnlyContextCollection CurrentContext { get; }
//            public EntityResult<TSchema> Source { get; }
//            TranslateResult<TSchema> TranslateContext<TSchema>.Result<TResult>(TResult result) => Result(result);
//
//            public TranslateResult<TSchema> Result(TSchema result, Type resultType) => throw new NotImplementedException();
//
//            public TranslateResult<TSchema> Empty<TResult>()
//            {
//                return new FakeTranslateResult<TSchema, TSchema>(this);
//            }
//
//            public TranslateResult<TSchema> NotTranslated<TResult>(TResult result)
//                where TResult : TSchema =>
//                throw new NotImplementedException();
//
//            public TranslateResult<TSchema> NotTranslated<TResult>()
//                where TResult : TSchema =>
//                throw new NotImplementedException();
//
//            public TranslateResult<TSchema> Empty()
//            {
//                return new FakeTranslateResult<TSchema, TSchema>(this);
//            }
//
//            public ITranslateResultCollection<TSchema> CreateResultCollection()
//            {
//                return new TranslateResultCollection<TSchema>(this);
//            }
//
//            public TranslateContext<T, TSchema> CreateContext<T>(T input, int? index = default) => throw new NotImplementedException();
//
//            public TranslateContext<T, TSchema> CreateContext<T>(int? index = default) => throw new NotImplementedException();
//
//            public TranslateResult<TSchema> Result<TResult>(TResult result)
//                where TResult : TSchema
//            {
//                return new FakeTranslateResult<TResult, TSchema>(this, result);
//            }
//        }
//
//
//
//            public class FakeTranslateResult<TResult, TSchema> :
//                TranslateResult<TSchema>
//                where TResult : TSchema
//                where TSchema : Entity
//            {
//                readonly TranslateContext<TSchema> _context;
//                readonly TResult _result;
//                readonly IReadOnlyContextCollection _contextSnapshot;
//                readonly Type _resultType;
//
//                public FakeTranslateResult(TranslateContext<TSchema> context, TResult result, bool isTranslated = true)
//                {
//                    _context = context;
//                    _result = result;
//                    _contextSnapshot = context.CurrentContext;
//                    _resultType = typeof(TResult);
//
//                    IsTranslated = isTranslated;
//                }
//
//                public FakeTranslateResult(TranslateContext<TSchema> context, bool isTranslated = true)
//                {
//                    _context = context;
//                    _result = default;
//                    _contextSnapshot = context.CurrentContext;
//                    _resultType = typeof(TResult);
//
//                    IsTranslated = isTranslated;
//                }
//
//                public bool TryGetEntity<T>(int index, out T entity)
//                    where T : TSchema
//                {
//                    if (index == 0 && typeof(T).IsAssignableFrom(_resultType))
//                    {
//                        object obj = _result;
//                        entity = (T) obj;
//                        return true;
//                    }
//
//                    entity = default;
//                    return false;
//
//                }
//
//                public ISchema<TSchema> Schema { get; }
//                public bool HasResult { get; }
//
//                public bool HasContext(Type contextType)
//                {
//                    return _contextSnapshot.HasContext(contextType);
//                }
//
//                public bool TryGetContext<T1>(out T1 context)
//                    where T1 : class => _contextSnapshot.TryGetContext(out context);
//
//                public bool IsTranslated { get; }
//                public EntityResult<TSchema> Source => _context.Source;
//            }



        class MessageTranslation :
            HL7Creation<HL7Entity>
        {
            public MessageTranslation()
            {
                Generate<MSHSegment>(x => x.Using<MSHTranslate>());
                Generate<PIDSegment>(x => x.Using<PIDTranslate>());
            }
        }
        
        class PIDTranslate :
            HL7SegmentCreation<PIDSegment, HL7Entity>
        {
            public PIDTranslate()
            {
                Set(x => x.SegmentId, x => x.Value("PID"));
                Set(x => x.PatientId, x => x.Using<PatientIdentifierTranslate>());
//                Set(x => x.PatientIdentifierList, x => x.Using<PatientIdentifierTranslate>());
            }
        }

        
        class PatientIdentifierTranslate :
            HL7ComponentCreation<CXComponent, HL7Entity>
        {
            public PatientIdentifierTranslate()
            {
                Set(x => x.IdNumber, x => x.Value(Guid.NewGuid().ToString()));
                Set(x => x.AssigningAuthority, x => x.Using<AssigningAuthorityTranslate>());
            }
        }

        
        class AssigningAuthorityTranslate :
            HL7ComponentCreation<HDComponent, HL7Entity>
        {
            public AssigningAuthorityTranslate()
            {
                Set(x => x.NamespaceId, x => x.Value("MACHETE"));
            }
        }
        
        
        class MSHTranslate :
            HL7SegmentCreation<MSHSegment, HL7Entity>
        {
            public MSHTranslate()
            {
                Set(x => x.SegmentId, x => x.Value("MSH"));
                Set(x => x.EncodingCharacters, x => x.Value(@"^~\&|"));
                Set(x => x.MessageType, x => x.Using<SetMessageTypeTranslate>());
                Set(x => x.SendingFacility, x => x.Value("MACHETE_PROVIDER"));
                Set(x => x.SendingApplication, x => x.Value("MACHETE_PROVIDER_APP"));
                Set(x => x.ReceivingFacility, x => x.Value("MACHETE_LAB"));
                Set(x => x.ReceivingApplication, x => x.Value("MACHETE_LAB_APP"));
                Set(x => x.MessageControlId, x => x.Value(Guid.NewGuid().ToString()));
                Set(x => x.CreationDateTime, x => x.Value(DateTimeOffset.UtcNow));
            }
        }

        
        class SetMessageTypeTranslate :
            HL7ComponentCreation<TestSchema.MSG, HL7Entity>
        {
            public SetMessageTypeTranslate()
            {
                Set(x => x.MessageCode, x => x.Value("ORM"));
                Set(x => x.TriggerEvent, x => x.Value("O01"));
            }
        }
    }
}