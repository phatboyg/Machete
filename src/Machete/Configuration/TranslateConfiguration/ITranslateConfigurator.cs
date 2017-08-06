namespace Machete.TranslateConfiguration
{
    public interface ITranslateConfigurator<TSchema>
        where TSchema : Entity
    {
        void Add(ITranslateSpecification<TSchema> specification);
    }
}