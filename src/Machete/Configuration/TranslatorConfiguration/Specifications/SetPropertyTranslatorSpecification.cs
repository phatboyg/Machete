namespace Machete.TranslatorConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Translators.PropertyTranslators;


    public class SetPropertyTranslatorSpecification<TResult, TProperty, TInput, TSchema> :
        PropertyTranslatorSpecification<TResult, TProperty, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly TProperty _propertyValue;

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
            var translator = new SetInputPropertyTranslator<TResult, TProperty, TInput, TSchema>(ResultPropertyInfo, _propertyValue);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}