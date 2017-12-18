namespace Machete.TranslatorConfiguration.Configurators
{
    using System;
    using System.Linq.Expressions;
    using Specifications;


    public class CreateEntityValueUsingConfigurator<TResult, TInput, TEntity, TSchema> :
        ICreateEntityUsingConfigurator<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TResult : TSchema
        where TInput : TSchema
    {
        readonly IEntityTranslatorConfigurator<TResult, TInput, TSchema> _configurator;
        readonly Expression<Func<TResult, Value<TEntity>>> _propertyExpression;

        public CreateEntityValueUsingConfigurator(IEntityTranslatorConfigurator<TResult, TInput, TSchema> configurator,
            Expression<Func<TResult, Value<TEntity>>> propertyExpression)
        {
            _configurator = configurator;
            _propertyExpression = propertyExpression;
        }

        public void Using<T>()
            where T : IEntityCreatorSpecification<TEntity, TSchema>, new()
        {
            var specification = new CreateEntityValueUsingSpecification<TResult, TInput, T, TEntity, TSchema>(_propertyExpression);

            _configurator.Add(specification);
        }

        public void By(Action<IEntityCreatorConfigurator<TEntity, TSchema>> configure)
        {
            var specification = new EntityCreatorSpecification<TEntity, TSchema>();

            configure?.Invoke(specification);

            var translateSpecification = new CreateEntityValueInlineSpecification<TResult, TInput, TEntity, TSchema>(_propertyExpression, specification);

            _configurator.Add(translateSpecification);
        }
    }
}