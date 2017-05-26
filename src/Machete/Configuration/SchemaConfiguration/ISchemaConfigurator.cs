namespace Machete.SchemaConfiguration
{
    public interface ISchemaConfigurator<in TSchema>
        where TSchema : Entity
    {
        void Add(ISchemaSpecification<TSchema> specification);

        /// <summary>
        /// Add all of the schema types in the namespace of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void AddFromNamespaceContaining<T>();
    }
}