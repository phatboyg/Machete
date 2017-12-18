namespace Machete
{
    using System.Threading.Tasks;


    public interface ITranslatorObserver<TSchema>
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
        Task PreTranslateEntity<TEntity, TInput>(TEntity entity, TranslateContext<TInput, TSchema> context);

        /// <summary>
        /// Called after an entity is translated
        /// </summary>
        /// <param name="result">The result of the translator</param>
        /// <param name="context"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        Task PostTranslateEntity<TInput>(TranslateResult<TSchema> result, TranslateContext<TInput, TSchema> context);

        /// <summary>
        /// Called after the entity factory creates the entity but before any translations
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="context"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        Task PreCreateEntity<TEntity>(TEntity entity, TranslateContext<TSchema> context);
        
        /// <summary>
        /// Called after the entity is created and translated
        /// </summary>
        /// <param name="result"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        Task PostCreateEntity(TranslateResult<TSchema> result, TranslateContext<TSchema> context);
    }
}