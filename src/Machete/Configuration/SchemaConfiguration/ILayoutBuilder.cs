namespace Machete.SchemaConfiguration
{
    using Layouts;


    public interface ILayoutBuilder<out TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
    {
        /// <summary>
        /// Return the layout for the specified layout type
        /// </summary>
        /// <typeparam name="T">The layout type</typeparam>
        /// <returns></returns>
        ILayoutParserFactory<T, TSchema> GetLayout<T>()
            where T : Layout;

        /// <summary>
        /// Adds a property to the layout
        /// </summary>
        /// <param name="property"></param>
        void Add(ILayoutProperty<TLayout, TSchema> property);
    }
}