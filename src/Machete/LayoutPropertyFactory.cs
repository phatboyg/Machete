namespace Machete
{
    public class LayoutPropertyFactory<T> :
        IListPropertyFactory<T, Layout<T>>
        where T : Layout
    {
        public Layout<T> CreateProperty()
        {
            return new LayoutProperty<T>();
        }

        public Layout<T> CreateProperty(T value)
        {
            return new LayoutProperty<T>(value);
        }

        public static readonly IListPropertyFactory<T, Layout<T>> Factory = new LayoutPropertyFactory<T>();
    }
}