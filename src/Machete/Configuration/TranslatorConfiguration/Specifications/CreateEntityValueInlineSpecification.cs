namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslators;


    public class CreateEntityValueInlineSpecification<TResult, TInput, TEntity, TSchema> :
        PropertyTranslatorSpecification<TResult, Value<TEntity>, TInput, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TResult : TSchema
        where TInput : TSchema
    {
        readonly IEntityCreatorSpecification<TEntity, TSchema> _specification;

        public CreateEntityValueInlineSpecification(Expression<Func<TResult, Value<TEntity>>> propertyExpression, IEntityCreatorSpecification<TEntity, TSchema> specification)
            : base(propertyExpression)
        {
            _specification = specification;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            return _specification.Validate();
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            IEntityCreator<TSchema> entityCreator = builder.CreateEntityCreator(_specification);

            var translator = new CreateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema>(ResultPropertyInfo, entityCreator);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }


    public class CreateEntityValueInlineSpecification<TResult, TEntity, TSchema> :
        PropertyCreatorSpecification<TResult, Value<TEntity>, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly IEntityCreatorSpecification<TEntity, TSchema> _specification;

        public CreateEntityValueInlineSpecification(Expression<Func<TResult, Value<TEntity>>> propertyExpression, IEntityCreatorSpecification<TEntity, TSchema> specification)
            : base(propertyExpression)
        {
            _specification = specification;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            return _specification.Validate();
        }

        public override void Apply(IEntityCreatorBuilder<TResult, TSchema> builder)
        {
            IEntityCreator<TSchema> entityCreator = builder.CreateEntityCreator(_specification);

            var translator = new CreateEntityValuePropertyTranslator<TResult, TEntity, TSchema>(ResultPropertyInfo, entityCreator);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}