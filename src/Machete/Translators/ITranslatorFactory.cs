namespace Machete.Translators
{
    public interface ITranslatorFactory<TSchema>
        where TSchema : Entity
    {
        ITranslator<TSchema> Create(TranslatorFactoryContext<TSchema> context);
    }
}