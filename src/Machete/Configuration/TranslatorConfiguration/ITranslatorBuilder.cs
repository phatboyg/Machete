namespace Machete.TranslatorConfiguration
{
    public interface ITranslatorBuilder<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Add an entity translator.
        /// </summary>
        /// <param name="translator">The translator</param>
        /// <typeparam name="T">The entity type</typeparam>
        void Add<T>(IEntityTranslator<T, TSchema> translator)
            where T : TSchema;

        /// <summary>
        /// Get a translator, specifying the factory if the translator doesn't already exist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> GetEntityTranslator<T, TInput, TTranslation>()
            where T : TSchema
            where TInput : TSchema
            where TTranslation : IEntityTranslatorSpecification<T, TInput, TSchema>, new();

        /// <summary>
        /// Create an entity translator, using the provided specification, and do not cache it.
        /// </summary>
        /// <param name="specification"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> CreateEntityTranslator<T, TInput>(IEntityTranslatorSpecification<T, TInput, TSchema> specification)
            where T : TSchema
            where TInput : TSchema;
    }
}