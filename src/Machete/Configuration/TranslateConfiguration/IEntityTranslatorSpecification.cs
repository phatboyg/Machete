namespace Machete.TranslateConfiguration
{
    using Configuration;


    public interface IEntityTranslatorSpecification<in TResult, TInput, TSchema> :
        ISpecification
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        string Name { get; }
        
        void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder);
    }
}