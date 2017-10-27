namespace Machete.Layouts.LayoutProperties
{
    using System;
    using System.Reflection;
    using Internals;
    using Internals.Reflection;
    using Parsers;


    public class LayoutLayoutProperty<TLayout, TSchema, T> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutPropertyWriter<TLayout, Layout<T>>
        where TSchema : Entity
        where TLayout : Layout
        where T : Layout
    {
        readonly ILayoutParserFactory<T, TSchema> _layout;
        readonly bool _required;
        readonly WriteProperty<TLayout, Layout<T>> _property;

        public LayoutLayoutProperty(Type implementationType, PropertyInfo property, ILayoutParserFactory<T, TSchema> layout, bool required)
        {
            _layout = layout;
            _required = required;
            _property = new WriteProperty<TLayout, Layout<T>>(implementationType, property.Name);
        }

        public IParser<TSchema, LayoutMatch<TLayout>> CreateQuery(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            IParser<TSchema, T> parser = _layout.CreateParser(options, queryBuilder);
            if (_required == false)
                parser = parser.Optional();

            return new LayoutLayoutParser<TLayout, TSchema, T>(parser, this);
        }

        public void SetProperty(TLayout layout, Layout<T> value)
        {
            _property.Set(layout, value);
        }
    }
}