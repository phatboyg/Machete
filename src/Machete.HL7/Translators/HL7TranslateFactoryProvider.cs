namespace Machete.HL7.Translators
{
    using Machete.Translators;
    using TranslateConfiguration;


    public class HL7TranslateFactoryProvider<TSchema> :
        ITranslateFactoryProvider<TSchema>
        where TSchema : HL7Entity
    {
        public ITranslateFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(ITranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new HL7TranslateFactory<TResult, TInput, TSchema>(specification);
        }
    }
}