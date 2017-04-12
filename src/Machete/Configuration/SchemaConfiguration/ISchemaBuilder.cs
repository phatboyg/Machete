namespace Machete.SchemaConfiguration
{
    using System;


    /// <summary>
    /// A schema builder combines schema specifications into a compiled schema
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface ISchemaBuilder<in TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Returns a dynamic implementation type for the schema type
        /// </summary>
        /// <typeparam name="T">The schema type</typeparam>
        /// <returns>A concrete type which backs the schema type</returns>
        Type GetImplementationType<T>()
            where T : TSchema;

        /// <summary>
        /// Return the schema mapper for the specified type
        /// </summary>
        /// <typeparam name="T">The schema type</typeparam>
        /// <returns></returns>
        IEntityMap<T> GetEntityMap<T>()
            where T : TSchema;

        /// <summary>
        /// Add an entity map to the builder
        /// </summary>
        /// <param name="map">The entity map</param>
        /// <typeparam name="T">The entity type</typeparam>
        void Add<T>(IEntityMap<T> map)
            where T : TSchema;
    }
}