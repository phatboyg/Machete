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
    }
}