namespace Machete.Translators
{
    using TranslateConfiguration;


    public interface ITranslatorFactoryProvider<TSchema>
        where TSchema : Entity
    {
        ITranslatorFactory<TSchema> GetTranslateFactory(ITranslatorSpecification<TSchema> specification);
    }
}