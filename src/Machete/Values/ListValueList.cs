namespace Machete.Values
{
    using System;
    using System.Collections.Generic;


    public class ListValueList<TValue> :
        ValueList<TValue>
    {
        readonly List<Value<TValue>> _values;

        public ListValueList()
        {
            _values = new List<Value<TValue>>();
        }

        public Type ValueType => typeof(TValue);
        public bool IsPresent => true;
        public bool HasValue => _values.Count > 0;

        public Value<TValue> this[int index]
        {
            get
            {
                if (index >= _values.Count || index < 0)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return _values[index];
            }
        }

        public bool TryGetValue(int index, out Value<TValue> value)
        {
            if (index >= _values.Count || index < 0)
            {
                value = Value.Missing<TValue>();
                return false;
            }

            value = _values[index];
            return true;
        }

        public void Add(TValue value)
        {
            _values.Add(new ConstantValue<TValue>(value));
        }

        public void Add(Value<TValue> value)
        {
            _values.Add(value);
        }
    }
}