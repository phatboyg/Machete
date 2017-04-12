namespace Machete
{
    using System;
    using System.Linq.Expressions;


    public class TemplateMap<TTemplate, TSchema>
        where TTemplate : Template<TSchema>, TSchema
        where TSchema : Entity
    {
        protected void Map<T>(Expression<Func<TTemplate, Entity<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema
        {
        }

        protected void Map<T>(Expression<Func<TTemplate, EntityList<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema
        {
        }

        protected void Map<T>(Expression<Func<TTemplate, Group<T>>> propertyExpression, int position, Action<IGroupConfigurator<T>> configure = null)
            where T : TSchema
        {
        }

        protected void Map<T>(Expression<Func<TTemplate, GroupList<T>>> propertyExpression, int position, Action<IGroupConfigurator<T>> configure = null)
            where T : TSchema
        {
        }
    }
}