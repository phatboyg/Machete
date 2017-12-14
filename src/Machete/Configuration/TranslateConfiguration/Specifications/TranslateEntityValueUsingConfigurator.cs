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
        readonly IEntityTranslatorConfigurator<TResult, TInput, TSchema> _configurator;
        readonly Expression<Func<TResult, Value<TEntity>>> _propertyExpression;

        public TranslateEntityValueUsingConfigurator(IEntityTranslatorConfigurator<TResult, TInput, TSchema> configurator,
            Expression<Func<TResult, Value<TEntity>>> propertyExpression)
        {
            _configurator = configurator;
            _propertyExpression = propertyExpression;
        }

        public void Using<T>()
            where T : IEntityTranslatorSpecification<TEntity, TEntity, TSchema>, new()
        {
            var specification = new TranslateEntityValueUsingSpecification<TResult, TInput, T, TEntity, TSchema>(_propertyExpression);

            _configurator.Add(specification);
        }

        public void By(Action<IEntityTranslatorConfigurator<TEntity, TEntity, TSchema>> configure)
        {
            var specification = new EntityTranslatorSpecification<TEntity, TEntity, TSchema>();

            configure?.Invoke(specification);

            var translateSpecification = new TranslateEntityValueInlineSpecification<TResult, TInput, TEntity, TSchema>(_propertyExpression, specification);

            _configurator.Add(translateSpecification);
        }
    }
}