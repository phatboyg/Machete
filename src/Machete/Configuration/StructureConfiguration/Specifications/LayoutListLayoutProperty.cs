namespace Machete.StructureConfiguration.Specifications
{
    using System.Reflection;
    using Internals.Reflection;


    public class LayoutListLayoutProperty<TLayout, TSchema, T> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutProperty<TLayout, TSchema, LayoutList<T>>
        where TSchema : Entity
        where TLayout : Layout
        where T : Layout
    {
        readonly ILayout<T, TSchema> _layout;
        readonly bool _required;
        readonly ReadWriteProperty<TLayout, LayoutList<T>> _property;

        public LayoutListLayoutProperty(PropertyInfo property,ILayout<T,TSchema> layout, bool required)
        {
            _layout = layout;
            _required = required;
            _property = new ReadWriteProperty<TLayout, LayoutList<T>>(property);
        }

        public Parser<TSchema, LayoutMatch<TLayout, TSchema>> CreateQuery(TemplateQueryOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            Parser<TSchema, T> parser = _layout.CreateQuery(options, queryBuilder);
            var listParser = _required ? parser.OneOrMore() : parser.ZeroOrMore();

            return new LayoutListLayoutParser<TLayout, TSchema, T>(listParser, this);
        }

        public void SetProperty(TLayout layout, LayoutList<T> value)
        {
            _property.Set(layout, value);
        }
    }
}