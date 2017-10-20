namespace Machete.X12.Translators
{
    using Machete.Translators;
    using TranslateConfiguration;


    public class X12EntityTranslateFactoryProvider<TSchema> :
        IEntityTranslateFactoryProvider<TSchema>
        where TSchema : X12Entity
    {
        public IEntityTranslateFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new X12EntityTranslateFactory<TResult, TInput, TSchema>(specification);
        }
    }
}