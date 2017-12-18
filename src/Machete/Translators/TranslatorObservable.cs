namespace Machete.Translators
{
    using System.Threading.Tasks;
    using Internals;


    class TranslatorObservable<TSchema> :
        Observable<ITranslatorObserver<TSchema>>,
        ITranslatorObserver<TSchema>
        where TSchema : Entity
    {
        public Task PreTranslateEntity<TEntity, TInput>(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            return ForEachAsync(x => x.PreTranslateEntity(entity, context));
        }

        public Task PostTranslateEntity<TInput>(TranslateResult<TSchema> result, TranslateContext<TInput, TSchema> context)
        {
            return ForEachAsync(x => x.PostTranslateEntity(result, context));
        }

        public Task PreCreateEntity<TEntity>(TEntity entity, TranslateContext<TSchema> context)
        {
            return ForEachAsync(x => x.PreCreateEntity(entity, context));
        }

        public Task PostCreateEntity(TranslateResult<TSchema> result, TranslateContext<TSchema> context)
        {
            return ForEachAsync(x => x.PostCreateEntity(result, context));
        }
    }
}