namespace Machete.TranslateConfiguration
{
    using System;


    public interface ITranslateBuilder<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Add an entity translator
        /// </summary>
        /// <param name="translator">The translator</param>
        /// <typeparam name="T">The entity type</typeparam>
        void Add<T>(IEntityTranslator<T, TSchema> translator)
            where T : TSchema;

        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <param name="translateSpecificationType"></param>
        /// <param name="translateFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> GetTranslator<T, TInput>(Type translateSpecificationType, Func<IEntityTranslateSpecification<T, TInput, TSchema>> translateFactory)
            where T : TSchema
            where TInput : TSchema;
    }
}