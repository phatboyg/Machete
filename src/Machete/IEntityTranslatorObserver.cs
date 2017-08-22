namespace Machete
{
    using System.Threading.Tasks;


    public interface IEntityTranslatorObserver<in TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        /// <summary>
        /// Called before an entity is translated
        /// </summary>
        /// <param name="entity">The entity to be translated</param>
        /// <param name="context"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        Task PreTranslateEntity<TInput>(TEntity entity, TranslateContext<TInput, TSchema> context)
            where TInput : TSchema;

        /// <summary>
        /// Called after an entity is translated
        /// </summary>
        /// <param name="entity">The entity that was translated</param>
        /// <param name="context"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        Task PostTranslateEntity<TInput>(TEntity entity, TranslateContext<TInput, TSchema> context)
            where TInput : TSchema;
    }
}