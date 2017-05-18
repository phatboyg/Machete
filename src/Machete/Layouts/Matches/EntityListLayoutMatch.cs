namespace Machete.Layouts.Matches
{
    using System.Collections.Generic;
    using Properties;


    public class EntityListLayoutMatch<TLayout, TEntity> :
        LayoutMatch<TLayout>
        where TLayout : Layout
        where TEntity : Entity
    {
        readonly ILayoutPropertyWriter<TLayout, EntityList<TEntity>> _property;
        readonly IReadOnlyList<TEntity> _entities;

        public EntityListLayoutMatch(ILayoutPropertyWriter<TLayout, EntityList<TEntity>> property, IReadOnlyList<TEntity> entities)
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