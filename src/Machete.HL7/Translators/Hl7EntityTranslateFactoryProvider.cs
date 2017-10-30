namespace Machete.HL7.Translators
{
    using Machete.TranslateConfiguration;
    using Machete.Translators;


    public class Hl7EntityTranslateFactoryProvider<TSchema> :
        IEntityTranslateFactoryProvider<TSchema>
        where TSchema : HL7Entity
    {
        public IEntityTranslatorFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new HL7EntityTranslatorFactory<TResult, TInput, TSchema>(specification);
        }
    }
}