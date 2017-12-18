namespace Machete.TranslatorConfiguration
{
    using Configuration;


    public interface IEntityCreatorSpecification<in TResult, TSchema> :
        ISpecification
        where TResult : TSchema
        where TSchema : Entity
    {
        string Name { get; }
        
        void Apply(IEntityCreatorBuilder<TResult, TSchema> builder);
    }
}