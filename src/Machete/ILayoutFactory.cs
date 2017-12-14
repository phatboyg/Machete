namespace Machete
{
    using System;


    public interface ILayoutFactory<out TLayout> :
        ILayoutFactory
        where TLayout : Layout
    {
        /// <summary>
        /// Create an instance of the entity
        /// </summary>
        /// <returns></returns>
        TLayout Create();
    }


    public interface ILayoutFactory
    {
        /// <summary>
        /// The schema type created by this factory
        /// </summary>
        Type LayoutType { get; }
    }
}