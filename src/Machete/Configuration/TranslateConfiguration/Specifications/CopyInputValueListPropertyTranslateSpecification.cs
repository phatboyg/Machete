namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators;
    using Translators.PropertyTranslaters;


    public class CopyInputValueListPropertyTranslateSpecification<TResult, TValue, TInput, TSchema> :
        PropertyTranslateSpecification<TResult, ValueList<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyInputValueListPropertyTranslateSpecification(Expression<Func<TResult, ValueList<TValue>>> propertyExpression) :
            base(propertyExpression)
        {
        }

        public CopyInputValueListPropertyTranslateSpecification(PropertyInfo propertyInfo) :
            base(propertyInfo)
        {
        }

        public CopyInputValueListPropertyTranslateSpecification(Expression<Func<TResult, ValueList<TValue>>> propertyExpression,
            Expression<Func<TInput, ValueList<TValue>>> inputPropertyExpression)
            : base(propertyExpression, inputPropertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(IEntityTranslateBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new CopyValueListPropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}