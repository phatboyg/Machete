namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators.PropertyTranslaters;


    public class SetPropertyTranslateSpecification<TResult, TProperty, TInput, TSchema> :
        PropertyTranslateSpecification<TResult, TProperty, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly TProperty _propertyValue;

        public SetPropertyTranslateSpecification(Expression<Func<TResult, TProperty>> propertyExpression, TProperty propertyValue)
            : base(propertyExpression)
        {
            _propertyValue = propertyValue;
        }

        public SetPropertyTranslateSpecification(PropertyInfo propertyInfo, TProperty propertyValue)
            : base(propertyInfo)
        {
            _propertyValue = propertyValue;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(ITranslateBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new SetPropertyTranslator<TResult, TProperty, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo,
                new StaticTranslatePropertyProvider<TProperty, TInput, TSchema>(_propertyValue));

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}