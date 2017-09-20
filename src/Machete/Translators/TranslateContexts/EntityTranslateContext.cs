namespace Machete.Translators.TranslateContexts
{
    using System;
    using Contexts;
    using Results;


    public class EntityTranslateContext<TInput, TSchema> :
        BaseContext,
        TranslateContext<TInput, TSchema>
        where TSchema : Entity
    {
        public EntityTranslateContext(EntityResult<TSchema> source, Result<Cursor<TSchema>, TInput> input, int? index = default(int?))
        {
            Source = source;

            HasInput = input.HasResult;
            if (input.HasResult)
                Input = input.Result;

            Index = index;
        }

        public EntityTranslateContext(EntityResult<TSchema> source, TInput input, bool hasInput, int? index = default(int?))
        {
            Source = source;

            HasInput = hasInput;
            Input = input;
            Index = index;
        }

        public EntityTranslateContext(IContextCache contextCache, EntityResult<TSchema> source, TInput input, bool hasInput, int? index = default(int?))
            : base(contextCache)
        {
            Source = source;

            HasInput = hasInput;
            Input = input;
            Index = index;
        }

        EntityTranslateContext(IReadOnlyContextCollection contextCollection, EntityResult<TSchema> source, TInput input, bool hasInput, int? index = default(int?))
            : base(contextCollection)
        {
            Source = source;

            HasInput = hasInput;
            Input = input;
            Index = index;
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
            return new EntityTranslateContext<T, TSchema>(Source, default(T), false, index);
        }

        public TInput Input { get; }
        public bool HasInput { get; }
        public int? Index { get; }

        bool TranslateContext<TInput, TSchema>.TryGetContext<T>(out TranslateContext<T, TSchema> context)
        {
            if (HasInput)
            {
                context = new EntityTranslateContext<T, TSchema>(ContextCache, Source, (T) Input, true, Index);
                return true;
            }

            context = new EntityTranslateContext<T, TSchema>(ContextCache, Source, default(T), false, Index);
            return false;
        }

        public TranslateContext<TInput, TSchema> CreateScope()
        {
            return new EntityTranslateContext<TInput, TSchema>(CurrentContext, Source, Input, HasInput, Index);
        }
    }
}