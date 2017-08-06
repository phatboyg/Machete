namespace Machete.Cursors.Contexts.Collections
{
    public class EmptyContextCollection :
        BaseContextCollection
    {
        public EmptyContextCollection(IReadOnlyContextCollection parent = null)
            : base(parent)
        {
        }

        public override IContextCollection Add(IContextValue context)
        {
            return new SingleContextCollection(context, Parent);
        }


        internal static class Shared
        {
            public static readonly EmptyContextCollection Empty = new EmptyContextCollection();
        }
    }
}