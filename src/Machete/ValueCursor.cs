namespace Machete
{
    using System;


    public readonly ref struct ValueCursor<T>
    {
        readonly ReadOnlySpan<T> _span;
        readonly int _index;

        public ValueCursor(ReadOnlySpan<T> span)
        {
            _span = span;
            _index = -1;

            HasCurrent = false;
            Current = default;
        }

        ValueCursor(ReadOnlySpan<T> span, int index)
        {
            _span = span;
            _index = index;

            HasCurrent = true;
            Current = span[index];
        }

        public readonly bool HasCurrent;
        public readonly T Current;

        public bool TryGetNext(out ValueCursor<T> next)
        {
            var nextIndex = _index + 1;

            if (nextIndex < _span.Length)
            {
                next = new ValueCursor<T>(_span, nextIndex);
                return true;
            }

            next = default;
            return false;
        }

        public bool Equals(ValueCursor<T> other)
        {
            return other._span == _span && other._index == _index;
        }
    }
}