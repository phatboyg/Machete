namespace Machete.Translators.TranslateContexts
{
    using System;
    using Contexts;
    using Results;


    /// <summary>
    /// The context of an entity being translated, where the entity is <typeparamref name="TInput"/>.
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public class EntityTranslateContext<TInput, TSchema> :
        TranslateContext<TInput, TSchema>
        where TSchema : Entity
    {
        readonly IContext _context;

        public EntityTranslateContext(EntityResult<TSchema> source, Result<Cursor<TSchema>, TInput> input, int? index = default)
        {
            Source = source;

            HasInput = input.HasResult;
            if (input.HasResult)
                Input = input.Result;

            Index = index;

            _context = new BaseContext();
        }

        public EntityTranslateContext(EntityResult<TSchema> source, TInput input, bool hasInput, int? index = default)
        {
            Source = source;

            HasInput = hasInput;
            Input = input;
            Index = index;

            _context = new BaseContext();
        }

        public EntityTranslateContext(IContext context, EntityResult<TSchema> source, TInput input, bool hasInput, int? index = default)
        {
            Source = source;

            HasInput = hasInput;
            Input = input;
            Index = index;

            _context = context;
        }

        EntityTranslateContext(IReadOnlyContextCollection contextCollection, EntityResult<TSchema> source, TInput input, bool hasInput, int? index = default)
        {
            Source = source;

            HasInput = hasInput;
            Input = input;
            Index = index;

            _context = new BaseContext(contextCollection);
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
            return new ResultTranslateResult<TSchema, TSchema>(this, result, false);
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
            return new EntityTranslateContext<T, TSchema>(Source, input, true, index);
        }

        public TranslateContext<T, TSchema> CreateContext<T>(int? index = null)
        {
            return new EntityTranslateContext<T, TSchema>(Source, default, false, index);
        }

        public TInput Input { get; }
        public bool HasInput { get; }
        public int? Index { get; }

        bool TranslateContext<TInput, TSchema>.TryGetContext<T>(out TranslateContext<T, TSchema> context)
        {
            if (HasInput)
            {
                context = new EntityTranslateContext<T, TSchema>(_context, Source, (T) Input, true, Index);
                return true;
            }

            context = new EntityTranslateContext<T, TSchema>(_context, Source, default(T), false, Index);
            return false;
        }

        public TranslateContext<TInput, TSchema> CreateScope()
        {
            return new EntityTranslateContext<TInput, TSchema>(_context.CurrentContext, Source, Input, HasInput, Index);
        }

        public TranslateValueContext<T, TInput, TSchema> CreateValueContext<T>(Value<T> value)
        {
            return new EntityValueTranslateContext<T, TInput, TSchema>(this, value);
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