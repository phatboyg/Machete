namespace Machete.HL7
{
    public abstract class HL7EntityTranslateMap<TResult, TInput, TSchema> :
        EntityTranslateMap<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }
}