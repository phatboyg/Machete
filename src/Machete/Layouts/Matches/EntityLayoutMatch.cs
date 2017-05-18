namespace Machete.Layouts.Matches
{
    public class EntityLayoutMatch<TLayout, TEntity> :
        LayoutMatch<TLayout>
        where TLayout : Layout
        where TEntity : Entity
    {
        readonly ILayoutPropertyWriter<TLayout, Entity<TEntity>> _property;
        readonly TEntity _entity;

        public EntityLayoutMatch(ILayoutPropertyWriter<TLayout, Entity<TEntity>> property, TEntity entity)
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