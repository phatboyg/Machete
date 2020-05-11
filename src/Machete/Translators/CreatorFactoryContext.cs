namespace Machete.Translators
{
    using TranslatorConfiguration;


    public interface CreatorFactoryContext<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Return the entity factory for the specified entity type
        /// </summary>
        /// <param name="factory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetEntityFactory<T>(out IEntityFactory<T> factory)
            where T : TSchema;

        /// <summary>
        /// Get a translator, specifying the factory if the translator doesn't already exist
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityCreator<TSchema> GetEntityCreator<TResult, TTranslation>()
            where TResult : TSchema
            where TTranslation : IEntityCreatorSpecification<TResult, TSchema>, new();

        /// <summary>
        /// Get a translator, specifying the factory if the translator doesn't already exist
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        IEntityCreator<TSchema> CreateEntityCreator<TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema;
    }
}