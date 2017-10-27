namespace Machete
{
    using System;


    public interface ILayout
    {
        /// <summary>
        /// The layout type
        /// </summary>
        Type LayoutType { get; }

        /// <summary>
        /// True if the layout has a value/is present
        /// </summary>
        bool HasValue { get; }
    }
}