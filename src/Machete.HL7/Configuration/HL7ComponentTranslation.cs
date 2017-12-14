namespace Machete.HL7
{
    public abstract class HL7ComponentTranslation<TResult, TInput, TSchema> :
        HL7EntityTranslation<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema, HL7Component
        where TResult : TSchema, HL7Component
    {
    }


    public abstract class HL7ComponentTranslation<TComponent, TSchema> :
        HL7ComponentTranslation<TComponent, TComponent, TSchema>
        where TSchema : HL7Entity
        where TComponent : TSchema, HL7Component
    {
    }
}