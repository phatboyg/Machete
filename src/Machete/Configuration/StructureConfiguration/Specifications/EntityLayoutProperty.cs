namespace Machete.StructureConfiguration.Specifications
{
    using System.Reflection;
    using Internals.Reflection;


    public class EntityLayoutProperty<TLayout, TSchema, TEntity> :
        ILayoutProperty<TLayout, TSchema>,
        ILayoutProperty<TLayout, TSchema, Entity<TEntity>>
        where TSchema : Entity
        where TLayout : Layout
        where TEntity : TSchema
    {
        readonly ReadWriteProperty<TLayout, Entity<TEntity>> _property;

        public EntityLayoutProperty(PropertyInfo property)
        {
            _property = new ReadWriteProperty<TLayout, Entity<TEntity>>(property);
        }

        public Parser<TSchema, LayoutMatch<TLayout, TSchema>> CreateQuery(TemplateQueryOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            return new EntityLayoutParser<TLayout, TSchema, TEntity>(queryBuilder.Select<TEntity>(), this);
        }

        public void SetProperty(TLayout layout, Entity<TEntity> value)
        {
            _property.Set(layout, value);
        }
    }
}