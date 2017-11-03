namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslaters;


    public class SetValuePropertyTranslateSpecification<TResult, TValue, TInput, TSchema> :
        PropertyTranslateSpecification<TResult, Value<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly SetValueProvider<TInput, TSchema, TValue> _valueProvider;

        public SetValuePropertyTranslateSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression, SetValueProvider<TInput, TSchema, TValue> valueProvider) :
            base(propertyExpression)
        {
            _valueProvider = valueProvider;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(IEntityTranslateBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new SetValuePropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, _valueProvider);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}