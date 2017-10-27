namespace Machete.Layouts
{
    using System;


    public class MissingLayout<TLayout> :
        Layout<TLayout>
        where TLayout : Layout
    {
        public Type LayoutType => typeof(TLayout);
        public bool HasValue => false;

        public TLayout Value => throw new LayoutMissingException("The layout is missing.");
    }
}