namespace Machete.HL7.Translators
{
    using Machete.TranslatorConfiguration;
    using Machete.Translators;


    public class HL7EntityTranslatorFactoryProvider<TSchema> :
        IEntityTranslatorFactoryProvider<TSchema>
        where TSchema : HL7Entity
    {
        public IEntityTranslatorFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new HL7EntityTranslatorFactory<TResult, TInput, TSchema>(specification);
        }

        public IEntityCreatorFactory<TSchema> GetCreatorFactory<TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema
        {
            return new HL7EntityCreatorFactory<TResult, TSchema>(specification);
        }
    }
}