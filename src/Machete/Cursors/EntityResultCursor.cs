namespace Machete.Cursors
{
    using System;
    using Contexts;


    /// <summary>
    /// Cursor for navigating an <see cref="EntityResult{TSchema}"/>.
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public struct EntityResultCursor<TSchema> :
        Cursor<TSchema>
        where TSchema : Entity
    {
        readonly EntityResult<TSchema> _entityResult;
        readonly int _index;
        readonly IContext _context;

        bool _nextComputed;
        Cursor<TSchema> _next;

        public EntityResultCursor(EntityResult<TSchema> entityResult)
        {
            _entityResult = entityResult;
            _index = -1;

            Current = default;
            HasCurrent = false;

            _context = new BaseContext();
            _next = null;
            _nextComputed = false;
        }

        EntityResultCursor(IContext context, EntityResult<TSchema> entityResult, int index, TSchema entity)
        {
            _entityResult = entityResult;
            _index = index;
            
            Current = entity;
            HasCurrent = true;

            _context = context;
            _next = null;
            _nextComputed = false;
        }

        public bool HasCurrent { get; }
        public TSchema Current { get; }

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

        public Cursor<TSchema> Next()
        {
            if (_nextComputed)
                return _next ?? Cursor.Empty<TSchema>();

            return GetNext() ?? Cursor.Empty<TSchema>();
        }

        Cursor<TSchema> GetNext()
        {
            int nextIndex = _index + 1;

            if (_entityResult.TryGetEntity(nextIndex, out TSchema entity))
            {
                _next = new EntityResultCursor<TSchema>(_context, _entityResult, nextIndex, entity);
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