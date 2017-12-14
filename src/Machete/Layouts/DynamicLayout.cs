namespace Machete.Layouts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Parsers;


    public class DynamicLayout<TLayout, TSchema> :
        ILayoutParserFactory<TLayout, TSchema>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly ILayoutFactory<TLayout> _factory;
        readonly ILayoutProperty<TLayout, TSchema>[] _properties;

        public DynamicLayout(ILayoutFactory<TLayout> factory, IEnumerable<ILayoutProperty<TLayout, TSchema>> properties)
        {
            _factory = factory;

            _properties = properties.ToArray();
        }

        Type ILayoutParserFactory.LayoutType => typeof(TLayout);

        public IParser<TSchema, TLayout> CreateParser(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            IParser<TSchema, LayoutMatch<TLayout>>[] queries = _properties.Select(property => property.CreateQuery(options, queryBuilder)).ToArray();

            return new LayoutParser<TLayout, TSchema>(_factory, queries);
        }
    }
}