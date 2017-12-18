namespace Machete.Translators
{
    using System;
    using TranslatorConfiguration;


    public interface CreatorFactoryContext<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Return the implementation type for the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Type GetImplementationType<T>();

        /// <summary>
        /// Return the entity factory for the specified entity type
        /// </summary>
        /// <param name="factory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetEntityFactory<T>(out IEntityFactory<T> factory)
            where T : TSchema;

        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityCreator<TSchema> GetEntityCreator<TResult, TTranslation>()
            where TResult : TSchema
            where TTranslation : IEntityCreatorSpecification<TResult, TSchema>, new();

        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        IEntityCreator<TSchema> CreateEntityCreator<TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema;
    }
}