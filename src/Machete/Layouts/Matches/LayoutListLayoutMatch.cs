namespace Machete.Layouts.Matches
{
    using System.Collections.Generic;
    using Properties;


    public class LayoutListLayoutMatch<TLayout, T> :
        LayoutMatch<TLayout>
        where TLayout : Layout
        where T : Layout
    {
        readonly ILayoutPropertyWriter<TLayout, LayoutList<T>> _property;
        readonly IReadOnlyList<T> _values;

        public LayoutListLayoutMatch(ILayoutPropertyWriter<TLayout, LayoutList<T>> property, IReadOnlyList<T> values)
        {
            _property = property;
            _values = values;
        }

        public void Apply(TLayout layout)
        {
            var propertyValue = new LayoutListProperty<T>(_values);

            _property.SetProperty(layout, propertyValue);
        }
    }
}