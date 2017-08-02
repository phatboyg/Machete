namespace Machete
{
    using System.Threading.Tasks;


    class TranslateEntityObservable<TEntity, TSchema> :
        Observable<ITranslateEntityObserver<TEntity, TSchema>>,
        ITranslateEntityObserver<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        public Task PreTranslateEntity<TInput>(TEntity entity, TranslateContext<TInput, TSchema> context)
            where TInput : TSchema
        {
            return ForEachAsync(x => x.PreTranslateEntity(entity, context));
        }

        public Task PostTranslateEntity<TInput>(TEntity entity, TranslateContext<TInput, TSchema> context)
            where TInput : TSchema
        {
            return ForEachAsync(x => x.PostTranslateEntity(entity, context));
        }
    }
}