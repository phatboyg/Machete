namespace Machete.Cursors
{
    using System;
    using System.Collections.Generic;
    using Contexts;


    public struct ListCursor<T> :
        Cursor<T>
    {
        readonly IReadOnlyList<T> _elements;
        readonly int _index;
        readonly IContext _context;

        bool _nextComputed;
        Cursor<T> _next;

        public ListCursor(IReadOnlyList<T> elements)
        {
            _elements = elements;
            _index = -1;

            Current = default;
            HasCurrent = false;
            
            _context = new BaseContext();
            _next = null;
            _nextComputed = false;
        }

        ListCursor(IContext context, IReadOnlyList<T> elements, int index, T entity)
        {
            _elements = elements;
            _index = index;
            
            Current = entity;
            HasCurrent = true;

            _context = context;
            _next = null;
            _nextComputed = false;
        }

        public bool HasCurrent { get; }
        public T Current { get; }

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
                _next = new ListCursor<T>(_context, _elements, nextIndex, _elements[nextIndex]);
            }

            _nextComputed = true;

            return _next;
        }

        bool IReadOnlyContext.HasContext(Type contextType)
        {
            return _context.HasContext(contextType);
        }

        bool IReadOnlyContext.TryGetContext<T>(out T context)
        {
            return _context.TryGetContext(out context);
        }

        T IContext.GetOrAddContext<T>(ContextFactory<T> contextFactory)
        {
            return _context.GetOrAddContext(contextFactory);
        }

        T IContext.AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
        {
            return _context.AddOrUpdateContext(addFactory, updateFactory);
        }

        IReadOnlyContextCollection IContext.CurrentContext => _context.CurrentContext;
    }
}