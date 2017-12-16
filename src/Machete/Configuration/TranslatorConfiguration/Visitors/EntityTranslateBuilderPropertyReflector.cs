namespace Machete.TranslatorConfiguration.Visitors
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Internals.Extensions;
    using Internals.Reflection;


    public class EntityTranslateBuilderPropertyReflector<TVisitor, TResult, TInput, TSchema> :
        ITranslateBuilderPropertyReflector<TVisitor, TSchema>
        where TVisitor : ITranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        public virtual void Property(TVisitor visitor, PropertyInfo property)
        {
            if (property.PropertyType.HasInterface(typeof(Value<>)))
            {
                var valueType = property.PropertyType.GetClosingArguments(typeof(Value<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("Value")
                    .MakeGenericMethod(valueType);

                CompileCallMethod(methodType)(visitor, property);
            }
            else if (property.PropertyType.HasInterface(typeof(ValueList<>)))
            {
                var valueType = property.PropertyType.GetClosingArguments(typeof(ValueList<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("ValueList")
                    .MakeGenericMethod(valueType);

                CompileCallMethod(methodType)(visitor, property);
            }
            else if (property.PropertyType.HasInterface(typeof(Entity<>)))
            {
                var entityType = property.PropertyType.GetClosingArguments(typeof(Entity<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("Entity")
                    .MakeGenericMethod(entityType);

                CompileCallMethod(methodType)(visitor, property);
            }
            else if (property.PropertyType.HasInterface(typeof(EntityList<>)))
            {
                var entityType = property.PropertyType.GetClosingArguments(typeof(EntityList<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("EntityList")
                    .MakeGenericMethod(entityType);

                CompileCallMethod(methodType)(visitor, property);
            }
            else if (property.PropertyType.HasInterface(typeof(Layout<>)))
            {
                var layoutType = property.PropertyType.GetClosingArguments(typeof(Layout<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("Layout")
                    .MakeGenericMethod(layoutType);

                CompileCallMethod(methodType)(visitor, property);
            }
            else if (property.PropertyType.HasInterface(typeof(LayoutList<>)))
            {
                var layoutType = property.PropertyType.GetClosingArguments(typeof(LayoutList<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("LayoutList")
                    .MakeGenericMethod(layoutType);

                CompileCallMethod(methodType)(visitor, property);
            }
        }

        protected static Action<TVisitor, PropertyInfo> CompileCallMethod(MethodInfo methodType)
        {
            var visitor = Expression.Parameter(typeof(TVisitor), "visitor");
            var propertyInfo = Expression.Parameter(typeof(PropertyInfo), "property");
            var call = Expression.Call(visitor, methodType, propertyInfo);
            var lambda = Expression.Lambda<Action<TVisitor, PropertyInfo>>(call, visitor, propertyInfo);

            return ExpressionCompiler.Compile<Action<TVisitor, PropertyInfo>>(lambda);
        }
    }
}