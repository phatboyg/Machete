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
        /// True if the layout is present
        /// </summary>
        bool IsPresent { get; }
    }
}