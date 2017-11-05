namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Linq.Expressions;


    public class TranslateEntityValueUsingConfigurator<TResult, TInput, TEntity, TSchema> :
        ITranslateEntityUsingConfigurator<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TResult : TSchema
        where TInput : TSchema
    {
        readonly IEntityTranslateConfigurator<TResult, TInput, TSchema> _configurator;
        readonly Expression<Func<TResult, Value<TEntity>>> _propertyExpression;

        public TranslateEntityValueUsingConfigurator(IEntityTranslateConfigurator<TResult, TInput, TSchema> configurator,
            Expression<Func<TResult, Value<TEntity>>> propertyExpression)
        {
            _configurator = configurator;
            _propertyExpression = propertyExpression;
        }

        public void Using<T>(Func<T> specificationFactory)
            where T : IEntityTranslateSpecification<TEntity, TEntity, TSchema>
        {
            var specification = new TranslateEntityValueUsingSpecification<TResult, TInput, T, TEntity, TSchema>(_propertyExpression, () => specificationFactory());

            _configurator.Add(specification);
        }

        public void Using<T>()
            where T : IEntityTranslateSpecification<TEntity, TEntity, TSchema>, new()
        {
            var specification = new TranslateEntityValueUsingSpecification<TResult, TInput, T, TEntity, TSchema>(_propertyExpression, () => new T());

            _configurator.Add(specification);
        }
    }
}