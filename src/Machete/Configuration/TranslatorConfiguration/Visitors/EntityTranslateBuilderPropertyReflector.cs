namespace Machete.TranslatorConfiguration.Visitors
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Internals.Extensions;
    using Internals.Reflection;


    public class EntityTranslateBuilderPropertyReflector<TVisitor, TSchema> :
        ITranslateBuilderPropertyReflector<TVisitor, TSchema>
        where TVisitor : ITranslateBuilderPropertyVisitor<TSchema>
        where TSchema : Entity
    {
        public virtual void Property(TVisitor visitor, PropertyInfo property)
        {
            if (property.PropertyType.HasInterface(typeof(Value<>)))
                HandlePropertyType(visitor, property, typeof(Value<>), "Value");
            else if (property.PropertyType.HasInterface(typeof(ValueList<>)))
                HandlePropertyType(visitor, property, typeof(ValueList<>), "ValueList");
            else if (property.PropertyType.HasInterface(typeof(Entity<>)))
                HandlePropertyType(visitor, property, typeof(Entity<>), "Entity");
            else if (property.PropertyType.HasInterface(typeof(EntityList<>)))
                HandlePropertyType(visitor, property, typeof(EntityList<>), "EntityList");
            else if (property.PropertyType.HasInterface(typeof(Layout<>)))
                HandlePropertyType(visitor, property, typeof(Layout<>), "Layout");
            else if (property.PropertyType.HasInterface(typeof(LayoutList<>)))
                HandlePropertyType(visitor, property, typeof(LayoutList<>), "LayoutList");
        }

        protected static Action<TVisitor, PropertyInfo> CompileCallMethod(MethodInfo methodType)
        {
            var visitor = Expression.Parameter(typeof(TVisitor), "visitor");
            var propertyInfo = Expression.Parameter(typeof(PropertyInfo), "property");
            var call = Expression.Call(visitor, methodType, propertyInfo);
            var lambda = Expression.Lambda<Action<TVisitor, PropertyInfo>>(call, visitor, propertyInfo);

            return ExpressionCompiler.Compile<Action<TVisitor, PropertyInfo>>(lambda);
        }

        void HandlePropertyType(TVisitor visitor, PropertyInfo property, Type type, string methodName)
        {
            var propertyType = property.PropertyType.GetClosingArguments(type).Single();

            var methodType = typeof(TVisitor)
                .GetMethod(methodName)
                ?.MakeGenericMethod(propertyType);

            CompileCallMethod(methodType)(visitor, property);
        }
    }
}