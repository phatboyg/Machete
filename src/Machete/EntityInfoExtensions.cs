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
            if (entity == null || propertyExpression == null)
            {
                valueInfo = ValueInfoHelper.Missing<TEntity>();
                return false;
            }

            var propertyInfo = propertyExpression.GetPropertyInfo();

            if (propertyInfo != null)
                return entity.EntityInfo.TryGetValueInfo(propertyInfo.Name, out valueInfo);
            
            valueInfo = ValueInfoHelper.Missing<TEntity>();
            return false;
        }
    }
}