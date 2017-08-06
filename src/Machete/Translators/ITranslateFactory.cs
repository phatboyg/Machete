namespace Machete.Translators
{
    public interface ITranslateFactory<TSchema>
        where TSchema : Entity
    {
        ITranslator<TSchema> Create(TranslateFactoryContext<TSchema> context);
    }
}