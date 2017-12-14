namespace Machete.Translators
{
    using System;
    using TranslateConfiguration;


    public interface TranslatorFactoryContext<TSchema>
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
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> GetEntityTranslator<TResult, TInput, TTranslation>()
            where TResult : TSchema
            where TInput : TSchema
            where TTranslation : IEntityTranslatorSpecification<TResult, TInput, TSchema>, new();

        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> CreateEntityTranslator<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema;

        Type GetImplementationType<T>();
    }
}