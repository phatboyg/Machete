namespace Machete.TranslateConfiguration
{
    public interface ITranslateConfigurator<TSchema>
        where TSchema : Entity
    {
        string Name { set; }
        
        void Add(ITranslateSpecification<TSchema> specification);
    }
}