namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslators;


    public class CreateEntityValueUsingSpecification<TResult, TInput, TDescription, TEntity, TSchema> :
        PropertyTranslatorSpecification<TResult, Value<TEntity>, TInput, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TDescription : IEntityCreatorSpecification<TEntity, TSchema>, new()
        where TResult : TSchema
        where TInput : TSchema
    {
        public CreateEntityValueUsingSpecification(Expression<Func<TResult, Value<TEntity>>> propertyExpression)
            : base(propertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            IEntityCreator<TSchema> entityTranslator = builder.GetEntityCreator<TEntity, TDescription>();

            var translator = new CreateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, entityTranslator);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}