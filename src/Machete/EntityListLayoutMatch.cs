namespace Machete
{
    using System.Collections.Generic;


    public class EntityListLayoutMatch<TLayout, TSchema, TEntity> :
        LayoutMatch<TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
        where TEntity : Entity
    {
        readonly ILayoutProperty<TLayout, TSchema, EntityList<TEntity>> _property;
        readonly IReadOnlyList<TEntity> _entities;

        public EntityListLayoutMatch(ILayoutProperty<TLayout, TSchema, EntityList<TEntity>> property, IReadOnlyList<TEntity> entities)
        {
            _property = property;
            _entities = entities;
        }

        public void Apply(TLayout layout)
        {
            var propertyValue = new EntityListProperty<TEntity>(_entities);

            _property.SetProperty(layout, propertyValue);
        }
    }
}