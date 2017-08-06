namespace Machete.Translators
{
    public interface IEntityTranslateFactory<TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
    {
        IEntityTranslator<TInput, TSchema> Create(TranslateFactoryContext<TSchema> context);
    }
}