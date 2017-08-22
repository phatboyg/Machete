namespace Machete.Translators
{
    using System.Threading.Tasks;
    using Internals;


    class EntityTranslatorObservable<TEntity, TSchema> :
        Observable<IEntityTranslatorObserver<TEntity, TSchema>>,
        IEntityTranslatorObserver<TEntity, TSchema>
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