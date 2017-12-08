namespace Machete.HL7
{
    public abstract class HL7EntityTranslation<TResult, TInput, TSchema> :
        EntityTranslation<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }
}