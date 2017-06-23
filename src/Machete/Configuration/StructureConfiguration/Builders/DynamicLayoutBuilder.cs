namespace Machete.StructureConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Layouts;
    using Specifications;


    public class DynamicLayoutBuilder<TLayout, TSchema> :
        ILayoutBuilder<TLayout, TSchema>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly IStructureBuilder<TSchema> _builder;
        readonly IList<ILayoutProperty<TLayout, TSchema>> _properties;

        public DynamicLayoutBuilder(IStructureBuilder<TSchema> builder)
        {
            _builder = builder;

            _properties = new List<ILayoutProperty<TLayout, TSchema>>();

            ImplementationType = builder.GetImplementationType<TLayout>();
        }

        public Type ImplementationType { get; }

        public ILayoutParserFactory<T, TSchema> GetLayout<T>()
            where T : Layout
        {
            return _builder.GetLayout<T>();
        }

        public void Add(ILayoutProperty<TLayout, TSchema> property)
        {
            _properties.Add(property);
        }

        public ILayoutParserFactory<TLayout, TSchema> Build()
        {
            var layoutFactory = new DynamicLayoutFactory<TLayout>(ImplementationType);

            return new DynamicLayout<TLayout, TSchema>(ImplementationType, layoutFactory, _properties);
        }
    }
}