namespace Machete.Cursors
{
    using System.Collections.Generic;


    public class ListCursor<T> :
        Cursor<T>
    {
        readonly IReadOnlyList<T> _elements;
        readonly int _index;

        bool _nextComputed;
        Cursor<T> _next;

        public ListCursor(IReadOnlyList<T> elements)
        {
            _elements = elements;
            _index = -1;
        }

        ListCursor(IReadOnlyList<T> elements, int index, T entity)
        {
            _elements = elements;
            _index = index;
            Value = entity;
            HasValue = true;
        }

        public bool HasValue { get; }
        public T Value { get; }

        public bool HasNext
        {
            get
            {
                if (_nextComputed)
                    return _next != null;

                GetNext();

                return _next != null;
            }
        }

        public Cursor<T> Next()
        {
            if (_nextComputed)
                return _next ?? Cursor.Empty<T>();

            return GetNext() ?? Cursor.Empty<T>();
        }

        Cursor<T> GetNext()
        {
            int nextIndex = _index + 1;

            if (nextIndex < _elements.Count)
            {
                _next = new ListCursor<T>(_elements, nextIndex, _elements[nextIndex]);
            }

            _nextComputed = true;

            return _next;
        }
    }
}