namespace Machete.Layouts.Properties
{
    using System.Collections.Generic;


    public abstract class PropertyList<T, TProperty>
        where TProperty : class
    {
        readonly IReadOnlyList<T> _values;
        readonly TProperty[] _properties;
        readonly IPropertyListItemFactory<T, TProperty> _itemFactory;

        protected PropertyList(IPropertyListItemFactory<T, TProperty> itemFactory, IReadOnlyList<T> values = null)
        {
            _values = values;
            _itemFactory = itemFactory;

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
                TryGetValue(index, out var value);

                return value;
            }
        }

        public bool TryGetValue(int index, out TProperty value)
        {
            if (index >= 0 && index < _values.Count)
            {
                value = _properties[index] ?? (_properties[index] = _itemFactory.Create(_values[index]));
                return true;
            }

            value = _itemFactory.CreateMissing();
            return false;
        }
    }
}