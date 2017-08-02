namespace Machete.TranslateConfiguration
{
    using System;


    public interface TranslateFactoryContext<TSchema>
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
        /// <param name="translateFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        ITranslator<T, TSchema> GetTranslator<T>(Type translateSpecificationType, Func<ITranslateFactory<T, TSchema>> translateFactory)
            where T : TSchema;

        Type GetImplementationType<T>();
    }
}