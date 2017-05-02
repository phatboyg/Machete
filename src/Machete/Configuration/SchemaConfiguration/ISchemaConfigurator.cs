namespace Machete.SchemaConfiguration
{
    public interface ISchemaConfigurator<in TEntity>
        where TEntity : Entity
    {
        void Add(ISchemaSpecification<TEntity> specification);

        /// <summary>
        /// Add all of the schema types in the namespace of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void AddFromNamespaceContaining<T>();
    }
}