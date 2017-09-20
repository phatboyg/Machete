namespace Machete.Contexts.Collections
{
    using System;


    public abstract class BaseContextCollection :
        IContextCollection
    {
        readonly IReadOnlyContextCollection _parent;

        protected BaseContextCollection(IReadOnlyContextCollection parent)
        {
            _parent = parent;
        }

        protected IReadOnlyContextCollection Parent => _parent;

        public IReadOnlyContextCollection CurrentContext => this;

        public virtual bool HasContext(Type contextType)
        {
            return _parent?.HasContext(contextType) ?? false;
        }

        public virtual bool TryGetContext<TPayload>(out TPayload context)
            where TPayload : class
        {
            if (_parent != null)
                return _parent.TryGetContext(out context);

            context = null;
            return false;
        }

        public abstract IContextCollection Add(IContextValue context);
    }
}