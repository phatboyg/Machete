namespace Machete.HL7
{
    using TranslateConfiguration;


    public class HL7TranslateMap<TResult, TInput, TSchema> :
        TranslateMap<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }
}