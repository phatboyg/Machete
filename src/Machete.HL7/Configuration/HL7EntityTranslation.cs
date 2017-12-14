namespace Machete.HL7
{
    public abstract class HL7EntityTranslation<TResult, TInput, TSchema> :
        EntityTranslation<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }


    public abstract class HL7EntityTranslation<TEntity, TSchema> :
        EntityTranslation<TEntity, TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
    }
}