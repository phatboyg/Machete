namespace Machete
{
    public class LayoutLayoutMatch<TLayout, TSchema, T> :
        LayoutMatch<TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
        where T : Layout
    {
        readonly ILayoutProperty<TLayout, TSchema, Layout<T>> _property;
        readonly T _layout;

        public LayoutLayoutMatch(ILayoutProperty<TLayout, TSchema, Layout<T>> property, T layout)
        {
            _property = property;
            _layout = layout;
        }

        public void Apply(TLayout layout)
        {
            var propertyValue = new LayoutProperty<T>(_layout);

            _property.SetProperty(layout, propertyValue);
        }
    }
}