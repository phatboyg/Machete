namespace Machete.Layouts.LayoutProperties
{
    using System;
    using System.Reflection;
    using Internals;
    using Internals.Reflection;
    using Parsers;


    public class EntityLayoutProperty<TLayout, TSchema, TEntity, TProperty> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutPropertyWriter<TLayout, Entity<TEntity>>
        where TSchema : Entity
        where TLayout : Layout
        where TEntity : TSchema
        where TProperty : Entity<TEntity>
    {
        readonly bool _required;
        readonly Func<Entity<TEntity>, TProperty> _propertyConverter;
        readonly WriteProperty<TLayout, TProperty> _property;

        public EntityLayoutProperty(Type implementationType, PropertyInfo property, bool required, Func<Entity<TEntity>, TProperty> propertyConverter)
        {
            _required = required;
            _propertyConverter = propertyConverter;
            _property = new WriteProperty<TLayout, TProperty>(implementationType, property.Name);
        }

        public Parser<TSchema, LayoutMatch<TLayout>> CreateQuery(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            Parser<TSchema, TEntity> parser = queryBuilder.Select<TEntity>();
            if (_required == false)
                parser = parser.Optional();

            return new EntityLayoutParser<TLayout, TSchema, TEntity>(parser, this);
        }

        public void SetProperty(TLayout layout, Entity<TEntity> value)
        {
            _property.Set(layout, _propertyConverter(value));
        }
    }
}