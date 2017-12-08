namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators;
    using Translators.PropertyTranslaters;


    public class CopyInputValueListPropertyTranslatorSpecification<TResult, TValue, TInput, TSchema> :
        PropertyTranslatorSpecification<TResult, ValueList<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyInputValueListPropertyTranslatorSpecification(Expression<Func<TResult, ValueList<TValue>>> propertyExpression) :
            base(propertyExpression)
        {
        }

        public CopyInputValueListPropertyTranslatorSpecification(PropertyInfo propertyInfo) :
            base(propertyInfo)
        {
        }

        public CopyInputValueListPropertyTranslatorSpecification(Expression<Func<TResult, ValueList<TValue>>> propertyExpression,
            Expression<Func<TInput, ValueList<TValue>>> inputPropertyExpression)
            : base(propertyExpression, inputPropertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new CopyValueListPropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}