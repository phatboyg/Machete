namespace Machete.TranslateConfiguration
{
    using System;
    using System.Linq.Expressions;
    using Specifications;


    public static class EntityTranslatorConfiguratorExtensions
    {
        public static void Set<TResult, TEntity, TSchema, T>(this IEntityTranslatorConfigurator<TResult, TEntity, TSchema> configurator,
            Expression<Func<TResult, Value<T>>> propertyExpression, SetValueProvider<TEntity, TSchema, T> valueProvider)
            where TSchema : Entity
            where TEntity : TSchema
            where TResult : TSchema
        {
            var specification = new SetValuePropertyTranslatorSpecification<TResult, T, TEntity, TSchema>(propertyExpression, valueProvider);

            configurator.Add(specification);
        }
    }
}