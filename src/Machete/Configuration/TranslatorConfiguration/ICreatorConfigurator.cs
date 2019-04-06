namespace Machete.TranslatorConfiguration
{
    public interface ICreatorConfigurator<TSchema>
        where TSchema : Entity
    {
        string Name { set; }
        
        void Add(ICreatorSpecification<TSchema> specification);
    }
}