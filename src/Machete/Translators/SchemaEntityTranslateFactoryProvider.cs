namespace Machete.Translators
{
    using TranslateConfiguration;


    public class SchemaEntityTranslateFactoryProvider<TSchema> : 
        IEntityTranslateFactoryProvider<TSchema>
        where TSchema : Entity
    {
        public IEntityTranslateFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new EntityTranslateFactory<TResult, TInput, TSchema>(specification);
        }
    }
}