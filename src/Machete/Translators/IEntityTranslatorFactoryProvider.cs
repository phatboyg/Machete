namespace Machete.Translators
{
    using TranslatorConfiguration;


    public interface IEntityTranslatorFactoryProvider<TSchema>
        where TSchema : Entity
    {
        IEntityTranslatorFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema;
    }
}