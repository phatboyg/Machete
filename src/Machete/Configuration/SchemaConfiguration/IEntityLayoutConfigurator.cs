namespace Machete.SchemaConfiguration
{
    public interface IEntityLayoutConfigurator<TSchema, TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        bool Required { set; }

        EntityLayoutCondition<TSchema, TEntity> Condition { set; }
    }
}