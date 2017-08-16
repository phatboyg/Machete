namespace Machete.SchemaConfiguration
{
    using Builders;


    public interface IEntityConfigurator<out TEntity>
        where TEntity : Entity
    {
        bool Required { set; }
    }


    /// <summary>
    /// Entity Configuration
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public interface IEntityConfigurator<TEntity, TSchema>
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
        void Add(string propertyName, IEntityPropertySpecification<TEntity, TSchema> specification);

        /// <summary>
        /// Set the entity type selector
        /// </summary>
        IEntitySelector EntitySelector { set; }

        /// <summary>
        /// Set the entity formatter factory
        /// </summary>
        EntityFormatterFactory<TEntity> FormatterFactory { set; }
    }
}