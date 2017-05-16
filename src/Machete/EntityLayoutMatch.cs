namespace Machete
{
    public class EntityLayoutMatch<TLayout, TSchema, TEntity> :
        LayoutMatch<TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
        where TEntity : Entity
    {
        readonly ILayoutProperty<TLayout, TSchema, Entity<TEntity>> _property;
        readonly TEntity _entity;

        public EntityLayoutMatch(ILayoutProperty<TLayout, TSchema, Entity<TEntity>> property, TEntity entity)
        {
            _property = property;
            _entity = entity;
        }

        public void Apply(TLayout layout)
        {
            var propertyValue = new EntityProperty<TEntity>(_entity);

            _property.SetProperty(layout, propertyValue);
        }
    }
}