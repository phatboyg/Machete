namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslators;


    public class SetValuePropertyCreatorSpecification<TResult, TValue, TSchema> :
        PropertyCreatorSpecification<TResult, Value<TValue>, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly SetValueProvider<TSchema, TValue> _valueProvider;

        public SetValuePropertyCreatorSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression, SetValueProvider<TSchema, TValue> valueProvider)
            : base(propertyExpression)
        {
            _valueProvider = valueProvider;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            return Enumerable.Empty<ValidateResult>();
        }

        public override void Apply(IEntityCreatorBuilder<TResult, TSchema> builder)
        {
            var translator = new SetValuePropertyTranslator<TResult, TValue, TSchema>(builder.ImplementationType, ResultPropertyInfo, _valueProvider);


            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}