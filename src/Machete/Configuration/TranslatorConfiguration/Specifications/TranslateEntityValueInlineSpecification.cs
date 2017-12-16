namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslators;


    public class TranslateEntityValueInlineSpecification<TResult, TInput, TEntity, TSchema> :
        PropertyTranslatorSpecification<TResult, Value<TEntity>, TInput, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TResult : TSchema
        where TInput : TSchema
    {
        readonly IEntityTranslatorSpecification<TEntity, TEntity, TSchema> _specification;

        public TranslateEntityValueInlineSpecification(Expression<Func<TResult, Value<TEntity>>> propertyExpression,
            IEntityTranslatorSpecification<TEntity, TEntity, TSchema> specification)
            : base(propertyExpression)
        {
            _specification = specification;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            return _specification.Validate();
        }

        public override IEnumerable<Type> GetReferencedTranslateTypes()
        {
            yield break;
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            IEntityTranslator<TEntity, TSchema> entityTranslator = builder.CreateEntityTranslator(_specification);

            var translator = new TranslateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo,
                entityTranslator);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}