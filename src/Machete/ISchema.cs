namespace Machete
{
    using System;
    using Formatters;
    using TranslatorConfiguration;


    public interface ISchema<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Map a parsed text fragment to an entity
        /// </summary>
        /// <param name="slice"></param>
        /// <param name="entity"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryConvertEntity<T>(TextSlice slice, out T entity)
            where T : TSchema;

        /// <summary>
        /// Retrieve an entity factory for the specified entity type
        /// </summary>
        /// <param name="entityFactory">The entity factory</param>
        /// <typeparam name="T">The entity type</typeparam>
        /// <returns>True if the entity factory exists, otherwise false</returns>
        bool TryGetEntityFactory<T>(out IEntityFactory<T> entityFactory)
            where T : TSchema;

        /// <summary>
        /// Retrieve and entity formatter for the specified entity type
        /// </summary>
        /// <param name="entityFormatter"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetEntityFormatter<T>(out IEntityFormatter<T> entityFormatter)
            where T : TSchema;

        /// <summary>
        /// Retrieve an entity formatter for the specified entity type
        /// </summary>
        /// <param name="entity">The entity to format</param>
        /// <param name="entityFormatter"></param>
        /// <returns></returns>
        bool TryGetEntityFormatter(TSchema entity, out IEntityFormatter entityFormatter);

        /// <summary>
        /// Returns the layout specified, if present.
        /// </summary>
        /// <param name="result"></param>
        /// <typeparam name="T">The layout type</typeparam>
        /// <returns></returns>
        bool TryGetLayout<T>(out ILayoutParserFactory<T, TSchema> result)
            where T : Layout;

        /// <summary>
        /// Create a translate using the specified translate specification
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> GetEntityTranslator<TResult, TInput, TTranslation>()
            where TResult : TSchema
            where TInput : TSchema
            where TTranslation : IEntityTranslatorSpecification<TResult, TInput, TSchema>, new();

        /// <summary>
        /// Returns a translator for the specified translation type
        /// </summary>
        /// <param name="translationType">The translate type used to create the translator</param>
        /// <returns></returns>
        ITranslator<TSchema> GetTranslator(Type translationType);

        /// <summary>
        /// Returns a translator for the specified translation type
        /// </summary>
        /// <typeparam name="T">The translation type, used to create the translator</typeparam>
        /// <returns></returns>
        ITranslator<TSchema> GetTranslator<T>()
            where T : ITranslatorSpecification<TSchema>, new();

        /// <summary>
        /// Retrieve a layout formatter for the specified layout type
        /// </summary>
        /// <param name="formatter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <returns></returns>
        bool TryGetLayoutFormatter<TLayout>(out ILayoutFormatter<TLayout> formatter)
            where TLayout : Layout;

        /// <summary>
        /// Retrieve a layout formatter for the specified layout type
        /// </summary>
        /// <param name="formatter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <returns></returns>
        bool TryGetLayoutFormatter<TLayout>(TLayout layout, out ILayoutFormatter formatter)
            where TLayout : Layout;
    }
}