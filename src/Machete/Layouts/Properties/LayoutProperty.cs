namespace Machete.Layouts.Properties
{
    using System;


    public class LayoutProperty<T> :
        Layout<T>
        where T : Layout
    {
        public LayoutProperty(T layout)
        {
            Value = layout;
            IsPresent = true;
            HasValue = true;
        }

        public LayoutProperty()
        {
            IsPresent = false;
            HasValue = false;
        }

        public Type LayoutType => typeof(T);

        public bool IsPresent { get; }

        public bool HasValue { get; }

        public T Value { get; }
    }
}