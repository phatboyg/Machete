namespace Machete.Cursors
{
    using System;
    using Contexts;


    public class StringCursor :
        Cursor<char>
    {
        readonly string _text;
        readonly int _index;
        readonly IContext _context;

        bool _nextComputed;
        Cursor<char> _next;

        public StringCursor(string text)
        {
            _text = text;
            _index = -1;

            _context = new BaseContext();
        }

        StringCursor(string text, int index)
        {
            _text = text;
            _index = index;
            HasCurrent = true;

            _context = new BaseContext();
        }

        public bool HasCurrent { get; }
        public char Current => _text[_index];

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

        public Cursor<char> Next()
        {
            if (_nextComputed)
                return _next ?? Cursor.Empty<char>();

            return GetNext() ?? Cursor.Empty<char>();
        }

        Cursor<char> GetNext()
        {
            int nextIndex = _index + 1;

            if (nextIndex < _text.Length)
            {
                _next = new StringCursor(_text, nextIndex);
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