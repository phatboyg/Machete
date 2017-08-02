namespace Machete.TranslateConfiguration
{
    using System;
    using Translators;


    public interface ITranslateBuilder<out TResult, out TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        /// <summary>
        /// The implementation type for this result
        /// </summary>
        Type ImplementationType { get; }

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

        /// <summary>
        /// Remove all translators from all properties
        /// </summary>
        void Clear();

        /// <summary>
        /// Remove all translators from the specified property
        /// </summary>
        /// <param name="propertyName"></param>
        void Clear(string propertyName);
    }
}