namespace Machete.HL7.Tests.TranslatorTests
{
    using System;
    using System.Threading.Tasks;
    using Contexts;
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
            var translator = Schema.CreateEntityTranslator<MSHSegment, NewEntityTranslate>();
            var translateResult = await translator.Translate(new FakeContext<HL7Entity>());

            Assert.IsTrue(translateResult.TryGetEntity(0, out MSHSegment translated));
            Assert.IsTrue(translated.MessageType.HasValue);
            Assert.AreEqual("ORM", translated.MessageType.Value.MessageCode.ValueOrDefault());
            Assert.AreEqual("O01", translated.MessageType.Value.TriggerEvent.ValueOrDefault());
        }


        public class FakeContext<TSchema> :
            TranslateContext<TSchema>
            where TSchema : Entity
        {
            public bool HasContext(Type contextType) => false;

            public bool TryGetContext<T>(out T context)
                where T : class =>
                throw new NotImplementedException();

            public T GetOrAddContext<T>(ContextFactory<T> contextFactory)
                where T : class =>
                throw new NotImplementedException();

            public T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
                where T : class =>
                throw new NotImplementedException();

            public IReadOnlyContextCollection CurrentContext { get; }
            public EntityResult<TSchema> Source { get; }
            TranslateResult<TSchema> TranslateContext<TSchema>.Result<TResult>(TResult result) => Result(result);

            public TranslateResult<TSchema> Result(TSchema result, Type resultType) => throw new NotImplementedException();

            public TranslateResult<TSchema> Empty<TResult>() => throw new NotImplementedException();

            public TranslateResult<TSchema> NotTranslated<TResult>(TResult result)
                where TResult : TSchema =>
                throw new NotImplementedException();

            public TranslateResult<TSchema> NotTranslated<TResult>()
                where TResult : TSchema =>
                throw new NotImplementedException();

            public TranslateResult<TSchema> Empty() => throw new NotImplementedException();

            public ITranslateResultCollection<TSchema> CreateResultCollection() => throw new NotImplementedException();

            public TranslateContext<T, TSchema> CreateContext<T>(T input, int? index = default) => throw new NotImplementedException();

            public TranslateContext<T, TSchema> CreateContext<T>(int? index = default) => throw new NotImplementedException();

            public TranslateResult<TSchema> Result<TResult>(TResult result)
                where TResult : TSchema
            {
                return new FakeTranslateResult<TResult, TSchema>(this, result);
            }


            public class FakeTranslateResult<TResult, TSchema> :
                TranslateResult<TSchema>
                where TResult : TSchema
                where TSchema : Entity
            {
                readonly TranslateContext<TSchema> _context;
                readonly TResult _result;
                readonly IReadOnlyContextCollection _contextSnapshot;
                readonly Type _resultType;

                public FakeTranslateResult(TranslateContext<TSchema> context, TResult result)
                {
                    _context = context;
                    _result = result;
                    _contextSnapshot = context.CurrentContext;
                    _resultType = typeof(TResult);
                }

                public bool TryGetEntity<T>(int index, out T entity)
                    where T : TSchema
                {
                    if (index == 0 && typeof(T).IsAssignableFrom(_resultType))
                    {
                        object obj = _result;
                        entity = (T) obj;
                        return true;
                    }

                    entity = default;
                    return false;

                }

                public ISchema<TSchema> Schema { get; }
                public bool HasResult { get; }

                public bool HasContext(Type contextType)
                {
                    return _contextSnapshot.HasContext(contextType);
                }

                public bool TryGetContext<T1>(out T1 context)
                    where T1 : class => _contextSnapshot.TryGetContext(out context);

                public bool IsTranslated { get; }
                public EntityResult<TSchema> Source => _context.Source;
            }
        }


        class NewEntityTranslate :
            HL7SegmentCreation<MSHSegment, HL7Entity>
        {
            public NewEntityTranslate()
            {
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
            HL7ComponentCreation<MSG, HL7Entity>
        {
            public SetMessageTypeTranslate()
            {
                Set(x => x.MessageCode, x => x.Value("ORM"));
                Set(x => x.TriggerEvent, x => x.Value("O01"));
            }
        }
    }
}