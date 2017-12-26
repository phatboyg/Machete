namespace Machete.Layouts.LayoutProperties
{
    using System;
    using System.Reflection;
    using Internals.Reflection;
    using Parsers;


    public class EntityListLayoutProperty<TLayout, TSchema, TEntity, TProperty> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutPropertyWriter<TLayout, EntityList<TEntity>>
        where TSchema : Entity
        where TLayout : Layout
        where TEntity : TSchema
        where TProperty : EntityList<TEntity>
    {
        readonly bool _required;
        readonly Func<EntityList<TEntity>, TProperty> _propertyConverter;
        readonly IWriteProperty<TLayout, TProperty> _property;

        public EntityListLayoutProperty(PropertyInfo property, bool required, Func<EntityList<TEntity>, TProperty> propertyConverter)
        {
            _required = required;
            _propertyConverter = propertyConverter;
            _property =  WritePropertyCache<TLayout>.GetProperty<TProperty>(property.Name);
        }

        public IParser<TSchema, LayoutMatch<TLayout>> CreateQuery(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            IParser<TSchema, TEntity> parser = queryBuilder.Select<TEntity>().Parser;
            var listParser = _required ? parser.OneOrMore() : parser.ZeroOrMore();

            return new EntityListLayoutParser<TLayout, TSchema, TEntity>(listParser, this);
        }

        public void SetProperty(TLayout layout, EntityList<TEntity> value)
        {
            _property.Set(layout, _propertyConverter(value));
        }
    }
}