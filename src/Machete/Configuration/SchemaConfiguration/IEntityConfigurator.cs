namespace Machete.SchemaConfiguration
{
    using Specifications;


    /// <summary>
    /// Entity Configuration
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public interface IEntityConfigurator<out TEntity, in TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// Set the name of the entity
        /// </summary>
        string Name { set; }


        /// <summary>
        /// Adds a property to this entity
        /// </summary>
        /// <param name="propertyName">The property name</param>
        /// <param name="specification">The property map specification</param>
        void Add(string propertyName, IEntityMapSpecification<TEntity, TSchema> specification);

        /// <summary>
        /// Set the entity type selector
        /// </summary>
        IEntityTypeSelector EntityTypeSelector { set; }
    }
}