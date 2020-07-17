namespace Machete.SchemaConfiguration
{
    public interface ISchemaConfigurator<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Add an entity schema type.
        /// </summary>
        /// <param name="specification"></param>
        void Add(ISchemaSpecification<TSchema> specification);

        /// <summary>
        /// Update an entity schema type.
        /// </summary>
        /// <param name="specification"></param>
        void Override(ISchemaSpecification<TSchema> specification);

        /// <summary>
        /// Add a layout schema type.
        /// </summary>
        /// <param name="specification"></param>
        void Add(ILayoutSpecification<TSchema> specification);

        /// <summary>
        /// Add all of the schema types in the namespace of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void AddFromNamespaceContaining<T>();
    }
}