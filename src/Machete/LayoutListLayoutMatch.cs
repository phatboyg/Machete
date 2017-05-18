namespace Machete
{
    using System.Collections.Generic;


    public class LayoutListLayoutMatch<TLayout, TSchema, T> :
        LayoutMatch<TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
        where T : Layout
    {
        readonly ILayoutProperty<TLayout, TSchema, LayoutList<T>> _property;
        readonly IReadOnlyList<T> _values;

        public LayoutListLayoutMatch(ILayoutProperty<TLayout, TSchema, LayoutList<T>> property, IReadOnlyList<T> values)
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