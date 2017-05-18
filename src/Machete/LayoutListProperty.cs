namespace Machete
{
    using System.Collections.Generic;


    public class LayoutListProperty<TLayout> :
        PropertyList<TLayout, Layout<TLayout>>,
        LayoutList<TLayout>
        where TLayout : Layout
    {
        public LayoutListProperty(IReadOnlyList<TLayout> layouts)
            : base(LayoutPropertyFactory<TLayout>.Factory, layouts)
        {
        }
    }
}