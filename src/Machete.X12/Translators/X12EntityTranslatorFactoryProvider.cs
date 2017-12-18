namespace Machete.X12.Translators
{
    using Machete.Translators;
    using TranslatorConfiguration;


    public class X12EntityTranslatorFactoryProvider<TSchema> :
        IEntityTranslatorFactoryProvider<TSchema>
        where TSchema : X12Entity
    {
        public IEntityTranslatorFactory<TInput, TSchema> GetTranslatorFactory<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new X12EntityTranslatorFactory<TResult, TInput, TSchema>(specification);
        }

        public IEntityCreatorFactory<TSchema> GetCreatorFactory<TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema
        {
            return new X12EntityCreatorFactory<TResult, TSchema>(specification);
        }
    }
}