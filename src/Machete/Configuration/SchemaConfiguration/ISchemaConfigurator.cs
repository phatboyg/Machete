namespace Machete.SchemaConfiguration
{
    public interface ISchemaConfigurator<in TEntity>
        where TEntity : Entity
    {
        void Add(ISchemaSpecification<TEntity> specification);
    }
}