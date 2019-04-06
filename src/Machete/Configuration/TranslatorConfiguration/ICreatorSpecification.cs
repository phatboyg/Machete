namespace Machete.TranslatorConfiguration
{
    using Configuration;


    public interface ICreatorSpecification<TSchema> :
        ISpecification
        where TSchema : Entity
    {
        string Name { get; }
        
        void Apply(ICreatorBuilder<TSchema> builder);
    }
}