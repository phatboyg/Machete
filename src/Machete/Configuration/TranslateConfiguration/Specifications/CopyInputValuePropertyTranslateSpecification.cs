namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators;


    public class CopyInputValuePropertyTranslateSpecification<TResult, TValue, TInput, TSchema> :
        PropertyTranslateSpecification<TResult, Value<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyInputValuePropertyTranslateSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression) :
            base(propertyExpression)
        {
        }

        public CopyInputValuePropertyTranslateSpecification(PropertyInfo propertyInfo) :
            base(propertyInfo)
        {
        }

        public CopyInputValuePropertyTranslateSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression,
            Expression<Func<TInput, Value<TValue>>> inputPropertyExpression)
            : base(propertyExpression, inputPropertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(IEntityTranslateBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new CopyValuePropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}