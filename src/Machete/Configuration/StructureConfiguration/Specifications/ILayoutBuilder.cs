namespace Machete.StructureConfiguration.Specifications
{
    using System;


    public interface ILayoutBuilder<out TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
    {
        /// <summary>
        /// The implementation type for this layout
        /// </summary>
        Type ImplementationType { get; }

        /// <summary>
        /// Return the layout for the specified layout type
        /// </summary>
        /// <typeparam name="T">The layout type</typeparam>
        /// <returns></returns>
        ILayout<T, TSchema> GetLayout<T>()
            where T : Layout;

        /// <summary>
        /// Adds a property to the layout
        /// </summary>
        /// <param name="property"></param>
        void Add(ILayoutProperty<TLayout, TSchema> property);
    }
}