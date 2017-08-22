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
    }
}