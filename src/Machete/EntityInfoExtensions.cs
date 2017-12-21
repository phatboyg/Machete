namespace Machete
{
    using System;
    using System.Linq.Expressions;
    using Internals.Extensions;


    public static class EntityInfoExtensions
    {
        public static bool TryGetValueInfo<TEntity, T>(this TEntity entity, Expression<Func<TEntity, T>> propertyExpression, out ValueInfo valueInfo)
            where TEntity : Entity
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var propertyName = propertyExpression.GetPropertyInfo().Name;

            return entity.EntityInfo.TryGetValueInfo(propertyName, out valueInfo);
        }
    }
}