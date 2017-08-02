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
        void Add(string propertyName, IEntityPropertyTranslator<TResult, TInput, TSchema> translator);
    }
}