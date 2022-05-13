namespace Machete.Layouts
{
    using System;


    /// <summary>
    /// Creates a layout using the dynamic implementation type.
    /// </summary>
    /// <typeparam name="TLayout"></typeparam>
    /// <typeparam name="TImplementation"></typeparam>
    public class DynamicLayoutFactory<TLayout, TImplementation> :
        ILayoutFactory<TLayout>
        where TLayout : Layout
        where TImplementation : TLayout, new()
    {
        public TLayout Create()
        {
            return new TImplementation();
        }

        Type ILayoutFactory.LayoutType => typeof(TLayout);
    }
}