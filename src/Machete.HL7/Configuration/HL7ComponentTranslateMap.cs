namespace Machete.HL7
{
    public abstract class HL7ComponentTranslateMap<TResult, TInput, TSchema> :
        HL7EntityTranslateMap<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema, HL7Component
        where TResult : TSchema, HL7Component
    {
    }
}