namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslators;


    public class TranslateEntityValueUsingSpecification<TResult, TInput, TTranslation, TEntity, TSchema> :
        PropertyTranslatorSpecification<TResult, Value<TEntity>, TInput, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TTranslation : IEntityTranslatorSpecification<TEntity, TEntity, TSchema>, new()
        where TResult : TSchema
        where TInput : TSchema
    {
        public TranslateEntityValueUsingSpecification(Expression<Func<TResult, Value<TEntity>>> propertyExpression)
            : base(propertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override IEnumerable<Type> GetReferencedTranslateTypes()
        {
            yield return typeof(TTranslation);
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            IEntityTranslator<TEntity, TSchema> entityTranslator = builder.GetEntityTranslator<TEntity, TEntity, TTranslation>();

            var translator = new TranslateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo,
                entityTranslator);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}