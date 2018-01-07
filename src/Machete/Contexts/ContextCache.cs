namespace Machete.Contexts
{
    using System;
    using System.Threading;
    using Collections;
    using Internals.Extensions;


    public class ContextCache :
        IContextCache
    {
        IContextCollection _collection;

        public ContextCache()
        {
            _collection = EmptyContextCollection.Shared.Empty;
        }

        public ContextCache(IReadOnlyContextCollection parent)
        {
            _collection = new EmptyContextCollection(parent);
        }

        public IReadOnlyContextCollection CurrentContext => Volatile.Read(ref _collection).CurrentContext;

        bool IReadOnlyContextCollection.HasContext(Type contextType)
        {
            return _collection.HasContext(contextType);
        }

        bool IReadOnlyContextCollection.TryGetContext<T>(out T context)
        {
            return _collection.TryGetContext(out context);
        }

        T IContextCache.GetOrAddContext<T>(ContextFactory<T> contextFactory)
        {
            try
            {
                IContextValue<T> context = null;

                IContextCollection currentCollection;
                do
                {
                    if (_collection.TryGetContext(out T existingValue))
                        return existingValue;

                    IContextValue<T> contextProperty = context ?? (context = new ContextValue<T>(contextFactory()));

                    currentCollection = Volatile.Read(ref _collection);

                    Interlocked.CompareExchange(ref _collection, currentCollection.Add(contextProperty), currentCollection);
                } while (currentCollection == Volatile.Read(ref _collection));

                return context.Value;
            }
            catch (Exception exception)
            {
                throw new ContextFactoryException($"The payload factory faulted: {TypeCache<T>.ShortName}", exception);
            }
        }

        T IContextCache.AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
        {
            try
            {
                T previousValue = null;
                IContextValue<T> context = null;

                IContextCollection currentCollection;
                do
                {
                    T existingValue;
                    if (_collection.TryGetContext(out existingValue))
                    {
                        if (context == null || previousValue != existingValue)

                            context = new ContextValue<T>(updateFactory(existingValue));

                        previousValue = existingValue;

                        currentCollection = Volatile.Read(ref _collection);

                        Interlocked.CompareExchange(ref _collection, currentCollection.Add(context), currentCollection);
                    }
                    else
                    {
                        if (context == null)
                            context = new ContextValue<T>(addFactory());

                        currentCollection = Volatile.Read(ref _collection);

                        Interlocked.CompareExchange(ref _collection, currentCollection.Add(context), currentCollection);
                    }
                } while (currentCollection == Volatile.Read(ref _collection));

                return context.Value;
            }
            catch (Exception exception)
            {
                throw new ContextFactoryException($"The payload factory faulted: {TypeCache<T>.ShortName}", exception);
            }
        }
    }
}