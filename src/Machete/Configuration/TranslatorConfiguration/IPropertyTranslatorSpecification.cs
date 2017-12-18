namespace Machete.TranslatorConfiguration
{
    using Configuration;


    public interface IPropertyTranslatorSpecification<in TResult, TInput, TSchema> :
        ISpecification
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder);
    }
}