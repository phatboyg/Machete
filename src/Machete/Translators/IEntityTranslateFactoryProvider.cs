namespace Machete.Translators
{
    using TranslateConfiguration;


    public interface IEntityTranslateFactoryProvider<TSchema>
        where TSchema : Entity
    {
        IEntityTranslateFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema;
    }
}