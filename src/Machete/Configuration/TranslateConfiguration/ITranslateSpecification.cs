namespace Machete.TranslateConfiguration
{
    using Configuration;


    public interface ITranslateSpecification<TResult, TInput, TSchema> :
        ISpecification
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        void Apply(ITranslateBuilder<TResult, TInput, TSchema> builder);

        void Add(IPropertyTranslateSpecification<TResult, TInput, TSchema> specification);
    }
}