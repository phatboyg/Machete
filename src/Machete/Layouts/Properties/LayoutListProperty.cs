namespace Machete.Layouts.Properties
{
    using System.Collections.Generic;


    public class LayoutListProperty<TLayout> :
        PropertyList<TLayout, Layout<TLayout>>,
        LayoutList<TLayout>
        where TLayout : Layout
    {
        public LayoutListProperty(IReadOnlyList<TLayout> layouts)
            : base(LayoutItemFactory<TLayout>.Factory, layouts)
        {
        }
    }
}