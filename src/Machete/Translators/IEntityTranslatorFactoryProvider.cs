namespace Machete.Translators
{
    using TranslatorConfiguration;


    public interface IEntityTranslatorFactoryProvider<TSchema>
        where TSchema : Entity
    {
        IEntityTranslatorFactory<TInput, TSchema> GetTranslatorFactory<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema;

        IEntityCreatorFactory<TSchema> GetCreatorFactory<TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema;
    }
}