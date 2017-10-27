namespace Machete.Translators.TranslateContexts
{
    using System;
    using Contexts;
    using Results;


    public class SchemaTranslateContext<TSchema> :
        TranslateContext<TSchema>
        where TSchema : Entity
    {
        readonly IContext _context;

        public SchemaTranslateContext(EntityResult<TSchema> source)
        {
            Source = source;

            _context = new BaseContext();
        }

        public EntityResult<TSchema> Source { get; }

        public TranslateResult<TSchema> Result<TResult>(TResult result)
            where TResult : TSchema
        {
            return new ResultTranslateResult<TResult, TSchema>(this, result);
        }

        public TranslateResult<TSchema> Result(TSchema result, Type resultType)
        {
            return new ResultTranslateResult<TSchema, TSchema>(this, result, resultType);
        }

        public TranslateResult<TSchema> Empty<TResult>()
        {
            return new ResultTranslateResult<TSchema, TSchema>(this);
        }

        public TranslateResult<TSchema> NotTranslated<TResult>(TResult result)
            where TResult : TSchema
        {
            return new ResultTranslateResult<TResult, TSchema>(this, result, false);
        }

        public TranslateResult<TSchema> NotTranslated<TResult>()
            where TResult : TSchema
        {
            return new ResultTranslateResult<TResult, TSchema>(this, false);
        }

        public TranslateResult<TSchema> Empty()
        {
            return new ResultTranslateResult<TSchema, TSchema>(this);
        }

        public ITranslateResultCollection<TSchema> CreateResultCollection()
        {
            return new TranslateResultCollection<TSchema>(this);
        }

        public TranslateContext<T, TSchema> CreateContext<T>(T input, int? index = null)
        {
            return new EntityTranslateContext<T, TSchema>(_context, Source, input, true, index);
        }

        public TranslateContext<T, TSchema> CreateContext<T>(int? index = null)
        {
            return new EntityTranslateContext<T, TSchema>(_context, Source, default(T), false, index);
        }

        bool IReadOnlyContext.HasContext(Type contextType)
        {
            return _context.HasContext(contextType);
        }

        bool IReadOnlyContext.TryGetContext<T>(out T context)
        {
            return _context.TryGetContext(out context);
        }

        T IContext.GetOrAddContext<T>(ContextFactory<T> contextFactory)
        {
            return _context.GetOrAddContext(contextFactory);
        }

        T IContext.AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
        {
            return _context.AddOrUpdateContext(addFactory, updateFactory);
        }

        IReadOnlyContextCollection IContext.CurrentContext => _context.CurrentContext;
    }
}