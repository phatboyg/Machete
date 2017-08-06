namespace Machete.Translators
{
    using TranslateConfiguration;


    public interface ITranslateFactoryProvider<TSchema>
        where TSchema : Entity
    {
        ITranslateFactory<TSchema> GetTranslateFactory(ITranslateSpecification<TSchema> specification);
    }
}