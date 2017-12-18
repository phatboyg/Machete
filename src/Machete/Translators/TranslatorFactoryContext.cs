namespace Machete.Translators
{
    using TranslatorConfiguration;


    public interface TranslatorFactoryContext<TSchema> : 
        CreatorFactoryContext<TSchema>
        where TSchema : Entity
    {
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
    }
}