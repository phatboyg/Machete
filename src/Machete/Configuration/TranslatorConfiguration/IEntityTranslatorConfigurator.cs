namespace Machete.TranslatorConfiguration
{
    using Configuration;


    public interface IEntityTranslatorConfigurator<out TResult, TInput, TSchema> :
        ISpecification
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        /// <summary>
        /// Sets the name of the entity translator
        /// </summary>
        string Name { set; }

        void Add(IPropertyTranslatorSpecification<TResult, TInput, TSchema> specification);
    }
}