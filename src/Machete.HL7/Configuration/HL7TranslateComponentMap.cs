namespace Machete.HL7
{
    public abstract class HL7TranslateComponentMap<TResult, TInput, TSchema> :
        HL7TranslateEntityMap<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema, HL7Component
        where TResult : TSchema, HL7Component
    {
    }
}