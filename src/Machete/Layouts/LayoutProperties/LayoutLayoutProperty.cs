namespace Machete.Layouts.LayoutProperties
{
    using System;
    using System.Reflection;
    using Internals;
    using Parsers;


    public class LayoutLayoutProperty<TLayout, TSchema, T> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutPropertyWriter<TLayout, Layout<T>>
        where TSchema : Entity
        where TLayout : Layout
        where T : Layout
    {
        readonly ILayout<T, TSchema> _layout;
        readonly bool _required;
        readonly WriteProperty<TLayout, Layout<T>> _property;

        public LayoutLayoutProperty(Type implementationType, PropertyInfo property, ILayout<T, TSchema> layout, bool required)
        {
            _layout = layout;
            _required = required;
            _property = new WriteProperty<TLayout, Layout<T>>(implementationType, property.Name);
        }

        public Parser<TSchema, LayoutMatch<TLayout>> CreateQuery(TemplateQueryOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            Parser<TSchema, T> parser = _layout.CreateQuery(options, queryBuilder);
            if (_required == false)
                parser = parser.FirstOrDefault();

            return new LayoutLayoutParser<TLayout, TSchema, T>(parser, this);
        }

        public void SetProperty(TLayout layout, Layout<T> value)
        {
            _property.Set(layout, value);
        }
    }
}