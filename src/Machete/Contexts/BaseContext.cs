namespace Machete.Contexts
{
    using System;
    using System.Threading;


    public struct BaseContext :
        IContext
    {
        IContextCache _contextCache;

        public BaseContext(IReadOnlyContextCollection parent)
        {
            _contextCache = new ContextCache(parent);
        }

        public BaseContext(IContext parent)
        {
            _contextCache = new ContextCache(parent.CurrentContext);
        }

        public bool HasContext(Type contextType)
        {
            return ContextCache.HasContext(contextType);
        }

        public bool TryGetContext<T>(out T context)
            where T : class
        {
            return ContextCache.TryGetContext(out context);
        }

        public T GetOrAddContext<T>(ContextFactory<T> contextFactory)
            where T : class
        {
            return ContextCache.GetOrAddContext(contextFactory);
        }

        public T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
            where T : class
        {
            return ContextCache.AddOrUpdateContext(addFactory, updateFactory);
        }

        public IReadOnlyContextCollection CurrentContext => ContextCache.CurrentContext;

        IContextCache ContextCache
        {
            get
            {
                if (_contextCache != null)
                    return _contextCache;
                
                while (Volatile.Read(ref _contextCache) == null)
                    Interlocked.CompareExchange(ref _contextCache, new ContextCache(), null);

                return _contextCache;
            }
        }
    }
}