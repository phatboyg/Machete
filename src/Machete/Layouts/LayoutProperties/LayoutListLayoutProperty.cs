namespace Machete.Layouts.LayoutProperties
{
    using System;
    using System.Reflection;
    using Internals;
    using Internals.Reflection;
    using Parsers;


    public class LayoutListLayoutProperty<TLayout, TSchema, T> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutPropertyWriter<TLayout, LayoutList<T>>
        where TSchema : Entity
        where TLayout : Layout
        where T : Layout
    {
        readonly ILayoutParserFactory<T, TSchema> _layout;
        readonly bool _required;
        readonly WriteProperty<TLayout, LayoutList<T>> _property;

        public LayoutListLayoutProperty(Type implementationType, PropertyInfo property, ILayoutParserFactory<T, TSchema> layout, bool required)
        {
            _layout = layout;
            _required = required;
            _property = new WriteProperty<TLayout, LayoutList<T>>(implementationType, property.Name);
        }

        public Parser<TSchema, LayoutMatch<TLayout>> CreateQuery(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            Parser<TSchema, T> parser = _layout.CreateParser(options, queryBuilder);
            var listParser = _required ? parser.OneOrMore() : parser.ZeroOrMore();

            return new LayoutListLayoutParser<TLayout, TSchema, T>(listParser, this);
        }

        public void SetProperty(TLayout layout, LayoutList<T> value)
        {
            _property.Set(layout, value);
        }
    }
}