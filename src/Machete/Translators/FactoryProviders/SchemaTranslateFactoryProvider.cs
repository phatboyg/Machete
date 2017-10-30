namespace Machete.Translators.FactoryProviders
{
    using TranslateConfiguration;


    public class SchemaTranslateFactoryProvider<TSchema> :
        ITranslateFactoryProvider<TSchema>
        where TSchema : Entity
    {
        public ITranslateFactory<TSchema> GetTranslateFactory(ITranslateSpecification<TSchema> specification)
        {
            return new TranslateFactory<TSchema>(specification);
        }
    }
}