namespace Machete.TranslateConfiguration
{
    using Translators;


    public interface IPropertyTranslateBuilder<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        void Add(IEntityPropertyTranslator<TResult, TInput, TSchema> translator);

        IEntityPropertyTranslator<TResult, TInput, TSchema> Build();

        /// <summary>
        /// Returns true if there are no definitions for the property
        /// </summary>
        bool IsDefined { get; }
    }
}