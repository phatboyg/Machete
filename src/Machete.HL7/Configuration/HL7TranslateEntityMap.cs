namespace Machete.HL7
{
    public class HL7TranslateEntityMap<TResult, TInput, TSchema> :
        TranslateEntityMap<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }
}