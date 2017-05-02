namespace Machete.SchemaConfiguration
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public interface IEntityMapSpecification<in TEntity, out TSchema> :
        ISpecification
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// Returns the entity types referenced by this property
        /// </summary>
        /// <returns></returns>
        IEnumerable<Type> GetReferencedEntityTypes();

        /// <summary>
        /// Apply the specification to the builder
        /// </summary>
        /// <param name="builder"></param>
        void Apply(IEntityMapBuilder<TEntity, TSchema> builder);
    }
}