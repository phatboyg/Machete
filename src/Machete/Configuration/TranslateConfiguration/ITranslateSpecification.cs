namespace Machete.TranslateConfiguration
{
    using Configuration;


    public interface ITranslateSpecification<TSchema> :
        ISpecification
        where TSchema : Entity
    {
        void Apply(ITranslateBuilder<TSchema> builder);
    }
}