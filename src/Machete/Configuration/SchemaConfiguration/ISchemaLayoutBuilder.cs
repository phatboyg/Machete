namespace Machete.SchemaConfiguration
{
    using System;
    using TranslateConfiguration;
    using Translators;


    public interface ISchemaLayoutBuilder<TSchema>
        where TSchema : Entity
    {
        Type GetImplementationType<T>()
            where T : Layout;

        /// <summary>
        /// Return a template map for the specified entity
        /// </summary>
        /// <typeparam name="T">The template type</typeparam>
        /// <returns></returns>
        ILayoutParserFactory<T, TSchema> GetLayout<T>()
            where T : Layout;

        /// <summary>
        /// Add a template map to the builder
        /// </summary>
        /// <param name="factory">The template map</param>
        /// <typeparam name="T">The template type</typeparam>
        void Add<T>(ILayoutParserFactory<T, TSchema> factory)
            where T : Layout;

        /// <summary>
        /// Specify the translate factory provider to use to build translators
        /// </summary>
        void SetTranslateFactoryProvider(IEntityTranslateFactoryProvider<TSchema> entityTranslateFactoryProvider);
    }
}