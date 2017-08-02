namespace Machete.TranslateConfiguration
{
    public interface ITranslateFactory<in TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
    {
        ITranslator<TInput, TSchema> Create(TranslateFactoryContext<TSchema> context);
    }
}