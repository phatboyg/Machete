namespace Machete.Cursors
{
    using System;
    using Contexts;


    public struct MemoryCursor<TMemory> :
        Cursor<TMemory>
    {
        readonly ReadOnlyMemory<TMemory> _memory;
        readonly int _index;
        readonly IContext _context;

        bool _nextComputed;
        Cursor<TMemory> _next;

        public MemoryCursor(ReadOnlyMemory<TMemory> memory)
        {
            _memory = memory;
            _index = -1;

            HasCurrent = false;

            _context = new BaseContext();
            _next = null;
            _nextComputed = false;
        }

        MemoryCursor(ReadOnlyMemory<TMemory> memory, int index)
        {
            _memory = memory;
            _index = index;

            HasCurrent = true;

            _context = new BaseContext();
            _next = null;
            _nextComputed = false;
        }

        public bool HasCurrent { get; }
        public TMemory Current => _memory.Span[_index];

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

        public Cursor<TMemory> Next()
        {
            if (_nextComputed)
                return _next ?? Cursor.Empty<TMemory>();

            return GetNext() ?? Cursor.Empty<TMemory>();
        }

        Cursor<TMemory> GetNext()
        {
            var nextIndex = _index + 1;

            if (nextIndex < _memory.Length)
                _next = new MemoryCursor<TMemory>(_memory, nextIndex);

            _nextComputed = true;

            return _next;
        }

        public bool HasContext(Type contextType)
        {
            return _context.HasContext(contextType);
        }

        public bool TryGetContext<T>(out T context)
            where T : class
        {
            return _context.TryGetContext(out context);
        }

        public T GetOrAddContext<T>(ContextFactory<T> contextFactory)
            where T : class
        {
            return _context.GetOrAddContext(contextFactory);
        }

        public T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
            where T : class
        {
            return _context.AddOrUpdateContext(addFactory, updateFactory);
        }

        public IReadOnlyContextCollection CurrentContext => _context.CurrentContext;
    }
}