namespace Machete.Translators
{
    using TranslatorConfiguration;


    public interface ITranslatorFactoryProvider<TSchema>
        where TSchema : Entity
    {
        ITranslatorFactory<TSchema> GetTranslateFactory(ITranslatorSpecification<TSchema> specification);
    }
}