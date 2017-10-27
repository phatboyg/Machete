namespace Machete.Layouts.Properties
{
    using System;
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

        public Type LayoutType => typeof(TLayout);
    }
}