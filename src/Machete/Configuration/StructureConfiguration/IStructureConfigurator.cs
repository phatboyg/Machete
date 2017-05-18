namespace Machete.StructureConfiguration
{
    public interface IStructureConfigurator<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Add a template
        /// </summary>
        /// <param name="specification"></param>
        void Add(ILayoutSpecification<TSchema> specification);

        /// <summary>
        /// Add the templates found in the namespace containing the specified type.
        /// </summary>
        /// <typeparam name="T">The search type</typeparam>
        void AddFromNamespaceContaining<T>();
    }
}