namespace Machete.HL7
{
    public abstract class HL7EntityCreation<TEntity, TSchema> :
        EntityCreation<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
    }
}