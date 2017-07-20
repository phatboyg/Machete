namespace Machete
{
    public static class LayoutSchema
    {
        public static Layout<T> Missing<T>()
            where T : Layout
        {
            return LayoutSchemaCached<T>.MissingLayout;
        }


        static class LayoutSchemaCached<T>
            where T : Layout
        {
            public static readonly Layout<T> MissingLayout = GetMissingLayout();

            static Layout<T> GetMissingLayout()
            {
                return new MissingLayout<T>();
            }
        }
    }
}