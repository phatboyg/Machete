namespace Machete.Cursors.Contexts.Collections
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
            TPayload payloadValue;
            if (_context.TryGetValue(out payloadValue))
            {
                context = payloadValue;
                return true;
            }

            return base.TryGetContext(out context);
        }

        public override IContextCollection Add(IContextValue context)
        {
            return new ArrayContextCollection(_parent, context, _context);
        }
    }
}