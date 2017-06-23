namespace Machete.StructureConfiguration
{
    using System;


    public interface IStructureBuilder<TSchema>
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
        /// <param name="map">The template map</param>
        /// <typeparam name="T">The template type</typeparam>
        void Add<T>(ILayoutParserFactory<T, TSchema> map)
            where T : Layout;
    }
}