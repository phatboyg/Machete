namespace Machete.Translators
{
    using TranslateConfiguration;


    public interface ITranslateFactoryProvider<TSchema>
        where TSchema : Entity
    {
        ITranslateFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(ITranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema;
    }
}