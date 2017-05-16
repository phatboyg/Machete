namespace Machete.StructureConfiguration.Specifications
{
    using System.Reflection;
    using Internals.Reflection;


    public class EntityListLayoutProperty<TLayout, TSchema, TEntity> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutProperty<TLayout, TSchema, EntityList<TEntity>>
        where TSchema : Entity
        where TLayout : Layout
        where TEntity : TSchema
    {
        readonly ReadWriteProperty<TLayout, EntityList<TEntity>> _property;

        public EntityListLayoutProperty(PropertyInfo property)
        {
            _property = new ReadWriteProperty<TLayout, EntityList<TEntity>>(property);
        }

        public Parser<TSchema, LayoutMatch<TLayout, TSchema>> CreateQuery(TemplateQueryOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            return new EntityListLayoutParser<TLayout, TSchema, TEntity>(queryBuilder.Select<TEntity>(), this);
        }

        public void SetProperty(TLayout layout, EntityList<TEntity> value)
        {
            _property.Set(layout, value);
        }
    }
}