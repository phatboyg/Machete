namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators.PropertyTranslators;


    public class CopyValuePropertyTranslatorSpecification<TResult, TValue, TInput, TSchema> :
        PropertyTranslatorSpecification<TResult, Value<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyValuePropertyTranslatorSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression) :
            base(propertyExpression)
        {
        }

        public CopyValuePropertyTranslatorSpecification(PropertyInfo propertyInfo) :
            base(propertyInfo)
        {
        }

        public CopyValuePropertyTranslatorSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression,
            Expression<Func<TInput, Value<TValue>>> inputPropertyExpression)
            : base(propertyExpression, inputPropertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            return Enumerable.Empty<ValidateResult>();
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new CopyValuePropertyTranslator<TResult, TValue, TInput, TSchema>(ResultPropertyInfo, InputPropertyInfo);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}