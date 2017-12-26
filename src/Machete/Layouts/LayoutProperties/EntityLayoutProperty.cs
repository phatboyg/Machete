namespace Machete.Layouts.LayoutProperties
{
    using System;
    using System.Reflection;
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
        readonly IWriteProperty<TLayout, TProperty> _property;

        public EntityLayoutProperty(PropertyInfo property, bool required, Func<Entity<TEntity>, TProperty> propertyConverter)
        {
            _required = required;
            _propertyConverter = propertyConverter;
            _property = WritePropertyCache<TLayout>.GetProperty<TProperty>(property.Name);
        }

        public IParser<TSchema, LayoutMatch<TLayout>> CreateQuery(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            IParser<TSchema, TEntity> parser = queryBuilder.Select<TEntity>().Parser;
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