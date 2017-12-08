namespace Machete.TranslateConfiguration
{
    using Configuration;


    public interface ITranslatorSpecification<TSchema> :
        ISpecification
        where TSchema : Entity
    {
        string Name { get; }
        
        void Apply(ITranslatorBuilder<TSchema> builder);
    }
}