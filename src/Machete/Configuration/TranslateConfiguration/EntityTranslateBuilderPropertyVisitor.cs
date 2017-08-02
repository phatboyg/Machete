namespace Machete.TranslateConfiguration
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Internals.Extensions;
    using Internals.Reflection;


    /// <summary>
    /// The default entity visitor, which just dispatches to known types
    /// </summary>
    public abstract class EntityTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> :
        ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        public virtual void Property(PropertyInfo property)
        {
            if (property.PropertyType.HasInterface(typeof(Value<>)))
            {
                Type valueType = property.PropertyType.GetClosingArguments(typeof(Value<>)).Single();

                var methodType = typeof(ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema>)
                    .GetMethod("Value")
                    .MakeGenericMethod(valueType);

                CompileCallMethod(methodType)(this, property);
            }
            else if (property.PropertyType.HasInterface(typeof(ValueList<>)))
            {
                Type valueType = property.PropertyType.GetClosingArguments(typeof(ValueList<>)).Single();

                var methodType = typeof(ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema>)
                    .GetMethod("ValueList")
                    .MakeGenericMethod(valueType);

                CompileCallMethod(methodType)(this, property);
            }
            else if (property.PropertyType.HasInterface(typeof(Entity<>)))
            {
                Type entityType = property.PropertyType.GetClosingArguments(typeof(Entity<>)).Single();
                Entity(property, entityType);
            }
            else if (property.PropertyType.HasInterface(typeof(EntityList<>)))
            {
                Type entityType = property.PropertyType.GetClosingArguments(typeof(EntityList<>)).Single();
                EntityList(property, entityType);
            }
            else if (property.PropertyType.HasInterface(typeof(Layout<>)))
            {
                Type entityType = property.PropertyType.GetClosingArguments(typeof(Layout<>)).Single();
                Layout(property, entityType);
            }
            else if (property.PropertyType.HasInterface(typeof(LayoutList<>)))
            {
                Type entityType = property.PropertyType.GetClosingArguments(typeof(LayoutList<>)).Single();
                LayoutList(property, entityType);
            }
        }

        static Action<ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema>, PropertyInfo> CompileCallMethod(MethodInfo methodType)
        {
            var visitor = Expression.Parameter(typeof(ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema>), "visitor");
            var propertyInfo = Expression.Parameter(typeof(PropertyInfo), "property");
            var call = Expression.Call(visitor, methodType, propertyInfo);
            var lambda = Expression.Lambda<Action<ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema>, PropertyInfo>>(call, visitor, propertyInfo);

            return ExpressionCompiler.Compile<Action<ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema>, PropertyInfo>>(lambda);
        }

        public abstract void Value<T>(PropertyInfo property);

        public abstract void ValueList<T>(PropertyInfo property);

        public abstract void Entity(PropertyInfo property, Type entityType);
        public abstract void EntityList(PropertyInfo property, Type entityType);
        public abstract void Layout(PropertyInfo property, Type layoutType);
        public abstract void LayoutList(PropertyInfo property, Type layoutType);
    }
}