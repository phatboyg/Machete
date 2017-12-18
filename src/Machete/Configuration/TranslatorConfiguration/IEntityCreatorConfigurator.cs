namespace Machete.TranslatorConfiguration
{
    using Configuration;


    public interface IEntityCreatorConfigurator<out TResult, TSchema> :
        ISpecification
        where TSchema : Entity
        where TResult : TSchema
    {
        string Name { set; }

        void Add(IPropertyCreatorSpecification<TResult, TSchema> specification);
    }
}