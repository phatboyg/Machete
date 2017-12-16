namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators.PropertyTranslators;
    using Translators.PropertyTranslators.PropertyProviders;


    public class SetPropertyTranslatorSpecification<TResult, TProperty, TInput, TSchema> :
        PropertyTranslatorSpecification<TResult, TProperty, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly TProperty _propertyValue;

        public SetPropertyTranslatorSpecification(Expression<Func<TResult, TProperty>> propertyExpression, TProperty propertyValue)
            : base(propertyExpression)
        {
            _propertyValue = propertyValue;
        }

        public SetPropertyTranslatorSpecification(PropertyInfo propertyInfo, TProperty propertyValue)
            : base(propertyInfo)
        {
            _propertyValue = propertyValue;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new SetPropertyTranslator<TResult, TProperty, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo,
                new StaticTranslatePropertyProvider<TProperty, TInput, TSchema>(_propertyValue));

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}