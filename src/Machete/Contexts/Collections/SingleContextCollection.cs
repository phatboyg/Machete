namespace Machete.Contexts.Collections
{
    using System;
    using System.Reflection;


    public class SingleContextCollection :
        BaseContextCollection
    {
        readonly IReadOnlyContextCollection _parent;
        readonly IContextValue _context;

        public SingleContextCollection(IContextValue context, IReadOnlyContextCollection parent = null)
            : base(parent)
        {
            _context = context;
            _parent = parent;
        }

        public override bool HasContext(Type contextType)
        {
            if (contextType.GetTypeInfo().IsAssignableFrom(_context.ValueType))
                return true;

            return base.HasContext(contextType);
        }

        public override bool TryGetContext<TPayload>(out TPayload context)
        {
            if (!_context.TryGetValue(out TPayload payloadValue))
                return base.TryGetContext(out context);

            context = payloadValue;
            return true;
        }

        public override IContextCollection Add(IContextValue context)
        {
            return new ArrayContextCollection(_parent, context, _context);
        }
    }
}