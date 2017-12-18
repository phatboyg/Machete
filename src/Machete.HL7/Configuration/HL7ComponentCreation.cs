namespace Machete.HL7
{
    public abstract class HL7ComponentCreation<TComponent, TSchema> :
        HL7EntityCreation<TComponent, TSchema>
        where TSchema : Entity
        where TComponent : TSchema
    {
    }
}