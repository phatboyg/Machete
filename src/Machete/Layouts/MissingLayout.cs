namespace Machete.Layouts
{
    using System;


    public class MissingLayout<TLayout> :
        Layout<TLayout>
        where TLayout : Layout
    {
        public Type LayoutType => typeof(TLayout);
        public bool IsPresent => false;

        public TLayout Value
        {
            get { throw new LayoutMissingException("The layout is missing."); }
        }
    }
}