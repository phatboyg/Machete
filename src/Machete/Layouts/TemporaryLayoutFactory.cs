namespace Machete.Layouts
{
    using System;
    using Machete.Internals.Extensions;

    public class TemporaryLayoutFactory<TLayout> :
        ILayoutFactory<TLayout>
        where TLayout : Layout
    {
        readonly Lazy<ILayoutFactory<TLayout>> _factory;

        public TemporaryLayoutFactory()
        {
            _factory = new Lazy<ILayoutFactory<TLayout>>(CreateFactory);
        }

        public Type LayoutType => typeof(TLayout);

        public TLayout Create()
        {
            return _factory.Value.Create();
        }

        ILayoutFactory<TLayout> CreateFactory()
        {
            var layoutFactoryType = typeof(DynamicLayoutFactory<,>).MakeGenericType(typeof(TLayout), TypeCache<TLayout>.ImplementationType);
            var layoutFactory = (ILayoutFactory<TLayout>)Activator.CreateInstance(layoutFactoryType);

            return layoutFactory;
        }
    }
}