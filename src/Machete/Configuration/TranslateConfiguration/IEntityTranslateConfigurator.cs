namespace Machete.TranslateConfiguration
{
    using Configuration;


    public interface IEntityTranslateConfigurator<out TResult, TInput, TSchema> :
        ISpecification
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        /// <summary>
        /// Sets the name of the entity translator
        /// </summary>
        string Name { set; }
        
        void Add(IPropertyTranslateSpecification<TResult, TInput, TSchema> specification);
    }
}