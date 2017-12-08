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
        /// <param name="translateSpecificationType"></param>
        /// <param name="specificationFactory"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> GetEntityTranslator<TResult, TInput>(Type translateSpecificationType,
            Func<IEntityTranslatorSpecification<TResult, TInput, TSchema>> specificationFactory)
            where TResult : TSchema
            where TInput : TSchema;

        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> GetEntityTranslator<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema;

        Type GetImplementationType<T>();
    }
}