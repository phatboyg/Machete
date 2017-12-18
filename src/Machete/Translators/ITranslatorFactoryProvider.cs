namespace Machete.Translators
{
    using TranslatorConfiguration;


    public interface ITranslatorFactoryProvider<TSchema>
        where TSchema : Entity
    {
        ITranslatorFactory<TSchema> GetTranslatorFactory(ITranslatorSpecification<TSchema> specification);
    }
}