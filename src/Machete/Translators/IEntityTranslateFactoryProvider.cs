namespace Machete.Translators
{
    using TranslateConfiguration;


    public interface IEntityTranslateFactoryProvider<TSchema>
        where TSchema : Entity
    {
        IEntityTranslatorFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema;
    }
}