namespace Machete
{
    using System;


    public class MissingLayout<TLayout> :
        Layout<TLayout>
        where TLayout : Layout
    {
        public Type LayoutType { get; } = typeof(TLayout);
        public bool IsPresent { get; } = false;
        public TLayout Value { get { throw new LayoutMissingException("The layout is missing."); } }
    }
}