namespace Machete.Translators
{
    using TranslateConfiguration;


    public class SchemaTranslateFactoryProvider<TSchema> : 
        ITranslateFactoryProvider<TSchema>
        where TSchema : Entity
    {
        public ITranslateFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(ITranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new TranslateFactory<TResult, TInput, TSchema>(specification);
        }
    }
}