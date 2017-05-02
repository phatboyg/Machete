namespace Machete.SchemaConfiguration
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public interface ISchemaSpecification<out TEntity> :
        ISpecification
        where TEntity : Entity
    {
        /// <summary>
        /// The entity type for this specification
        /// </summary>
        Type EntityType { get; }

        /// <summary>
        /// Returns the entity types referenced by this entity
        /// </summary>
        /// <returns></returns>
        IEnumerable<Type> GetReferencedEntityTypes();

        /// <summary>
        /// Apply the specification to the builder
        /// </summary>
        /// <param name="builder"></param>
        void Apply(ISchemaBuilder<TEntity> builder);
    }
}