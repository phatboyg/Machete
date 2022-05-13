namespace Machete.TranslatorConfiguration
{
    using Translators.PropertyTranslators;


    public interface IEntityCreatorBuilder<out TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        /// <summary>
        /// Get a translator, specifying the factory if the translator doesn't already exist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TDescription"></typeparam>
        /// <returns></returns>
        IEntityCreator<TSchema> GetEntityCreator<T, TDescription>()
            where T : TSchema
            where TDescription : IEntityCreatorSpecification<T, TSchema>, new();

        /// <summary>
        /// Get a translator, specifying the factory if the translator doesn't already exist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEntityCreator<TSchema> CreateEntityCreator<T>(IEntityCreatorSpecification<T, TSchema> specification)
            where T : TSchema;

        /// <summary>
        /// Adds a setter for a property by name.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="translator"></param>
        void Add(string propertyName, IPropertyTranslator<TResult, TSchema> translator);

        /// <summary>
        /// Remove all translators from all properties.
        /// </summary>
        void Clear();

        /// <summary>
        /// Remove all translators from the specified property.
        /// </summary>
        /// <param name="propertyName"></param>
        void Clear(string propertyName);
    }
}