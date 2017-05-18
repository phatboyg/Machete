namespace Machete.Layouts.Properties
{
    using System.Collections.Generic;


    public abstract class PropertyList<T, TProperty>
        where TProperty : class
    {
        readonly IReadOnlyList<T> _values;
        readonly TProperty[] _properties;
        readonly IListPropertyFactory<T, TProperty> _propertyFactory;

        protected PropertyList(IListPropertyFactory<T, TProperty> propertyFactory, IReadOnlyList<T> values = null)
        {
            _values = values;
            _propertyFactory = propertyFactory;

            _properties = new TProperty[values?.Count ?? 0];

            IsPresent = values != null;
            HasValue = values != null;
        }

        public bool IsPresent { get; }
        public bool HasValue { get; }

        public TProperty this[int index]
        {
            get
            {
                if (index < _values.Count)
                    return _properties[index] ?? (_properties[index] = _propertyFactory.CreateProperty(_values[index]));

                return _propertyFactory.CreateProperty();
            }
        }

        public bool TryGetValue(int index, out TProperty value)
        {
            if (index < _values.Count)
            {
                value = _properties[index] ?? (_properties[index] = _propertyFactory.CreateProperty(_values[index]));
                return true;
            }

            value = default(TProperty);
            return false;
        }
    }
}