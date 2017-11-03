namespace Machete.TranslateConfiguration
{
    using Configuration;


    public interface ITranslateSpecification<TSchema> :
        ISpecification
        where TSchema : Entity
    {
        string Name { get; }
        
        void Apply(ITranslateBuilder<TSchema> builder);
    }
}