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
        IEntityConverter<T> GetEntityConverter<T>()
            where T : TSchema;

        /// <summary>
        /// Return the schema mapper for the specified type
        /// </summary>
        /// <typeparam name="T">The schema type</typeparam>
        /// <returns></returns>
        IEntityFormatter<T> GetEntityFormatter<T>()
            where T : TSchema;

        /// <summary>
        /// Add an entity converter to the builder
        /// </summary>
        /// <param name="converter">The entity converter</param>
        /// <typeparam name="T">The entity type</typeparam>
        void Add<T>(IEntityConverter<T> converter)
            where T : TSchema;

        /// <summary>
        /// Add an entity converter to the builder
        /// </summary>
        /// <param name="formatter">The entity converter</param>
        /// <typeparam name="T">The entity type</typeparam>
        void Add<T>(IEntityFormatter<T> formatter)
            where T : TSchema;
    }
}