namespace Machete.TranslateConfiguration
{
    using Configuration;


    public interface IEntityTranslateSpecification<in TResult, TInput, TSchema> :
        ISpecification
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        void Apply(IEntityTranslateBuilder<TResult, TInput, TSchema> builder);
    }
}