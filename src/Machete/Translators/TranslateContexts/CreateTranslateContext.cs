namespace Machete.Translators.TranslateContexts
{
    using System;
    using Contexts;
    using Results;


    public class CreateTranslateContext<TSchema> :
        TranslateContext<TSchema>
        where TSchema : Entity
    {
        public CreateTranslateContext(EntityResult<TSchema> source)
        {
            Source = source;
        }

        public CreateTranslateContext()
        {
        }

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

        public TranslateResult<TSchema> Result<TResult>(TResult result)
            where TResult : TSchema => new CreateTranslateResult<TResult, TSchema>(this, result);

        public TranslateResult<TSchema> Result(TSchema result, Type resultType) => new CreateTranslateResult<TSchema, TSchema>(this, result);

        public TranslateResult<TSchema> Empty<TResult>() => throw new NotImplementedException();

        public TranslateResult<TSchema> NotTranslated<TResult>(TResult result)
            where TResult : TSchema =>
            throw new NotImplementedException();

        public TranslateResult<TSchema> NotTranslated<TResult>()
            where TResult : TSchema =>
            throw new NotImplementedException();

        public TranslateResult<TSchema> Empty() => throw new NotImplementedException();

        public ITranslateResultCollection<TSchema> CreateResultCollection() => new TranslateResultCollection<TSchema>(this);

        public TranslateContext<T, TSchema> CreateContext<T>(T input, int? index = default) => throw new NotImplementedException();

        public TranslateContext<T, TSchema> CreateContext<T>(int? index = default) => throw new NotImplementedException();
    }
}