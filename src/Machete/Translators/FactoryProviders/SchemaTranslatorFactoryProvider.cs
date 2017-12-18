namespace Machete.Translators.FactoryProviders
{
    using TranslatorConfiguration;


    public class SchemaTranslatorFactoryProvider<TSchema> :
        ITranslatorFactoryProvider<TSchema>
        where TSchema : Entity
    {
        public ITranslatorFactory<TSchema> GetTranslatorFactory(ITranslatorSpecification<TSchema> specification)
        {
            return new TranslatorFactory<TSchema>(specification);
        }
    }
}