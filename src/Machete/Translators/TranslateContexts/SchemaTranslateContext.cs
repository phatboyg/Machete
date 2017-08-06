namespace Machete.Translators.TranslateContexts
{
    using System;
    using Cursors;
    using Cursors.Contexts;
    using Results;


    public class SchemaTranslateContext<TSchema> :
        BaseContext,
        TranslateContext<TSchema>
        where TSchema : Entity
    {
        public SchemaTranslateContext(EntityResult<TSchema> source)
        {
            Source = source;
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
            return new EntityTranslateContext<T, TSchema>(ContextCache, Source, input, true, index);
        }

        public TranslateContext<T, TSchema> CreateContext<T>(int? index = null)
        {
            return new EntityTranslateContext<T, TSchema>(ContextCache, Source, default(T), false, index);
        }
    }
}