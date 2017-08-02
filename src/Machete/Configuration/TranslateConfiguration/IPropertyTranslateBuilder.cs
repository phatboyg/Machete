namespace Machete.TranslateConfiguration
{
    using Translators;


    public interface IPropertyTranslateBuilder<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        /// <summary>
        /// Returns true if there are no definitions for the property
        /// </summary>
        bool IsDefined { get; }

        void Add(IPropertyTranslator<TResult, TInput, TSchema> translator);

        /// <summary>
        /// Clear all translators from the property
        /// </summary>
        void Clear();

        /// <summary>
        /// Build the property translator
        /// </summary>
        /// <returns></returns>
        IPropertyTranslator<TResult, TInput, TSchema> Build();
    }
}