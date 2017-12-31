namespace Machete.SchemaConfiguration.Builders
{
    using System.Collections.Generic;
    using Layouts;

    public class DynamicLayoutBuilder<TLayout, TSchema> :
        ILayoutBuilder<TLayout, TSchema>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly ISchemaLayoutBuilder<TSchema> _builder;
        readonly IList<ILayoutProperty<TLayout, TSchema>> _properties;

        public DynamicLayoutBuilder(ISchemaLayoutBuilder<TSchema> builder)
        {
            _builder = builder;

            _properties = new List<ILayoutProperty<TLayout, TSchema>>();
        }

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
            return new DynamicLayout<TLayout, TSchema>(new TemporaryLayoutFactory<TLayout>(), _properties);
        }
    }
}