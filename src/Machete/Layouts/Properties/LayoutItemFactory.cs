namespace Machete.Layouts.Properties
{
    public class LayoutItemFactory<T> :
        IPropertyListItemFactory<T, Layout<T>>
        where T : Layout
    {
        public Layout<T> CreateMissing()
        {
            return new LayoutProperty<T>();
        }

        public Layout<T> Create(T value)
        {
            return new LayoutProperty<T>(value);
        }

        public static readonly IPropertyListItemFactory<T, Layout<T>> Factory = new LayoutItemFactory<T>();
    }
}