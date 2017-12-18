namespace Machete.Translators.FactoryProviders
{
    using TranslatorConfiguration;


    public class SchemaEntityTranslatorFactoryProvider<TSchema> :
        IEntityTranslatorFactoryProvider<TSchema>
        where TSchema : Entity
    {
        public IEntityTranslatorFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new EntityTranslatorFactory<TResult, TInput, TSchema>(specification);
        }

        public IEntityCreatorFactory<TSchema> GetCreatorFactory<TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema
        {
            return new EntityCreatorFactory<TResult, TSchema>(specification);
        }
    }
}