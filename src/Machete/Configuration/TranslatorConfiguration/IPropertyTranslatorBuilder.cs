namespace Machete.TranslatorConfiguration
{
    using Translators.PropertyTranslators;


    /// <summary>
    /// Translate a property on an entity, used by entity translators
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public interface IPropertyTranslatorBuilder<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        /// <summary>
        /// Returns true if there are no definitions for the property
        /// </summary>
        bool IsDefined { get; }

        void Add(IInputPropertyTranslator<TResult, TInput, TSchema> translator);

        /// <summary>
        /// Clear all translators from the property
        /// </summary>
        void Clear();

        /// <summary>
        /// Build the property translator
        /// </summary>
        /// <returns></returns>
        IInputPropertyTranslator<TResult, TInput, TSchema> Build();
    }


    /// <summary>
    /// Translate a property on an entity, used by entity translators
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public interface IPropertyTranslatorBuilder<TResult, TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        /// <summary>
        /// Returns true if there are no definitions for the property
        /// </summary>
        bool IsDefined { get; }

        void Add(IPropertyTranslator<TResult, TSchema> translator);

        /// <summary>
        /// Clear all translators from the property
        /// </summary>
        void Clear();

        /// <summary>
        /// Build the property translator
        /// </summary>
        /// <returns></returns>
        IPropertyTranslator<TResult, TSchema> Build();
    }
}