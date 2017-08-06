namespace Machete.HL7.Translators
{
    using Machete.TranslateConfiguration;
    using Machete.Translators;


    public class Hl7EntityTranslateFactoryProvider<TSchema> :
        IEntityTranslateFactoryProvider<TSchema>
        where TSchema : HL7Entity
    {
        public IEntityTranslateFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new Hl7EntityTranslateFactory<TResult, TInput, TSchema>(specification);
        }
    }
}