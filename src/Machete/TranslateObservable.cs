namespace Machete
{
    using System.Threading.Tasks;


    class TranslateObservable<TSchema> :
        Observable<ITranslateObserver<TSchema>>,
        ITranslateObserver<TSchema>
        where TSchema : Entity
    {
        public Task PreTranslateEntity<TEntity, TInput>(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            return ForEachAsync(x => x.PreTranslateEntity(entity, context));
        }

        public Task PostTranslateEntity<TEntity, TInput>(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            return ForEachAsync(x => x.PostTranslateEntity(entity, context));
        }
    }
}