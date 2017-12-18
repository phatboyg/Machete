namespace Machete.TranslatorConfiguration
{
    using Translators.PropertyTranslators;


    public interface IEntityTranslatorBuilder<out TResult, TInput, TSchema> :
        IEntityCreatorBuilder<TResult, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TIn, TSchema> GetEntityTranslator<T, TIn, TTranslation>()
            where T : TSchema
            where TIn : TSchema
            where TTranslation : IEntityTranslatorSpecification<T, TIn, TSchema>, new();

        /// <summary>
        /// Get a translater, specifying the factory if the translater doesn't already exist
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TIn"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TIn, TSchema> CreateEntityTranslator<T, TIn>(IEntityTranslatorSpecification<T, TIn, TSchema> specification)
            where T : TSchema
            where TIn : TSchema;

        /// <summary>
        /// Adds a translater for a property by name
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="translator"></param>
        void Add(string propertyName, IPropertyTranslator<TResult, TInput, TSchema> translator);

        /// <summary>
        /// Copy all values from the input to the result, assigning unmatched properties to Missing
        /// </summary>
        void CopyAll();

        /// <summary>
        /// Exclude all properties from the input, assiging all unassigned properties to Missing
        /// </summary>
        void ExcludeAll();
    }
}