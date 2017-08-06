namespace Machete.Cursors
{
    using System;
    using Contexts;
    using Contexts.Collections;


    public class EmptyCursor<T> :
        Cursor<T>
    {
        public bool HasValue => false;

        public T Value => default(T);

        public bool HasNext => false;

        public Cursor<T> Next()
        {
            throw new InvalidOperationException("There is no next cursor.");
        }

        public bool HasContext(Type contextType)
        {
            return false;
        }

        public bool TryGetContext<TPayload>(out TPayload context)
            where TPayload : class
        {
            context = default(TPayload);
            return false;
        }

        public TPayload GetOrAddContext<TPayload>(ContextFactory<TPayload> contextFactory)
            where TPayload : class
        {
            throw new ContextNotFoundException();
        }

        public TPayload AddOrUpdateContext<TPayload>(ContextFactory<TPayload> addFactory, UpdateContextFactory<TPayload> updateFactory)
            where TPayload : class
        {
            throw new ContextNotFoundException();
        }

        public IReadOnlyContextCollection CurrentContext => EmptyContextCollection.Shared.Empty;
    }
}