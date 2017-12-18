namespace Machete.TranslatorConfiguration
{
    using Configuration;


    public interface IPropertyCreatorSpecification<in TResult, TSchema> :
        ISpecification
        where TSchema : Entity
        where TResult : TSchema
    {
        void Apply(IEntityCreatorBuilder<TResult, TSchema> builder);
    }
}