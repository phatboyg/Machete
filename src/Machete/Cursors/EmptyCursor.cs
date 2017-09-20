namespace Machete.Cursors
{
    using System;
    using Contexts;
    using Contexts.Collections;


    public class EmptyCursor<TInput> :
        Cursor<TInput>
    {
        public bool HasCurrent => false;
        public TInput Current => throw new InvalidOperationException("The cursor is empty, Current is not valid.");
        public bool HasNext => false;

        public Cursor<TInput> Next()
        {
            throw new InvalidOperationException("The cursor is empty, Next is not a valid operation.");
        }

        public bool HasContext(Type contextType)
        {
            return false;
        }

        public bool TryGetContext<T>(out T context)
            where T : class
        {
            context = default(T);
            return false;
        }

        public T GetOrAddContext<T>(ContextFactory<T> contextFactory)
            where T : class
        {
            throw new ContextNotFoundException();
        }

        public T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
            where T : class
        {
            throw new ContextNotFoundException();
        }

        public IReadOnlyContextCollection CurrentContext => EmptyContextCollection.Shared.Empty;
    }
}