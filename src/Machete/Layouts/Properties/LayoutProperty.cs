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

            HasValue = layout != null;
        }

        public LayoutProperty()
        {
        }

        public Type LayoutType => typeof(T);

        public bool HasValue { get; }
        
        public T Value { get; }
    }
}