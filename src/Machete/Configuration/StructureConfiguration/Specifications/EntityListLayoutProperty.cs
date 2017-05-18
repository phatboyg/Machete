namespace Machete.StructureConfiguration.Specifications
{
    using System;
    using System.Reflection;
    using Internals.Reflection;


    public class EntityListLayoutProperty<TLayout, TSchema, TEntity, TProperty> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutProperty<TLayout, TSchema, EntityList<TEntity>>
        where TSchema : Entity
        where TLayout : Layout
        where TEntity : TSchema
        where TProperty : EntityList<TEntity>
    {
        readonly bool _required;
        readonly Func<EntityList<TEntity>, TProperty> _propertyConverter;
        readonly ReadWriteProperty<TLayout, TProperty> _property;

        public EntityListLayoutProperty(PropertyInfo property, bool required, Func<EntityList<TEntity>, TProperty> propertyConverter)
        {
            _required = required;
            _propertyConverter = propertyConverter;
            _property = new ReadWriteProperty<TLayout, TProperty>(property);
        }

        public Parser<TSchema, LayoutMatch<TLayout, TSchema>> CreateQuery(TemplateQueryOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            Parser<TSchema, TEntity> parser = queryBuilder.Select<TEntity>();
            var listParser = _required ? parser.OneOrMore() : parser.ZeroOrMore();

            return new EntityListLayoutParser<TLayout, TSchema, TEntity>(listParser, this);
        }

        public void SetProperty(TLayout layout, EntityList<TEntity> value)
        {
            _property.Set(layout, _propertyConverter(value));
        }
    }
}