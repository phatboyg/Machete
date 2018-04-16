namespace Machete.Formatters
{
    using System;


    public interface ILayoutFormatter<in TLayout> :
        ILayoutFormatter
        where TLayout : Layout
    {
        /// <summary>
        /// Format a layout.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="layout"></param>
        void Format(FormatContext context, TLayout layout);
    }


    public interface ILayoutFormatter
    {
        Type LayoutType { get; }

        void Format<T>(FormatContext context, T layout);
    }
}