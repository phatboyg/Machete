namespace Machete.Layouts.Matches
{
    using Properties;


    public class LayoutLayoutMatch<TLayout, TSchema, T> :
        LayoutMatch<TLayout>
        where TLayout : Layout
        where TSchema : Entity
        where T : Layout
    {
        readonly ILayoutPropertyWriter<TLayout, Layout<T>> _property;
        readonly T _layout;

        public LayoutLayoutMatch(ILayoutPropertyWriter<TLayout, Layout<T>> property, T layout)
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