namespace Machete.TranslatorConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Configuration;
    using Translators.PropertyTranslators;


    public class SetPropertyCreatorSpecification<TResult, TProperty, TSchema> :
        PropertyCreatorSpecification<TResult, TProperty, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly TProperty _propertyValue;

        public SetPropertyCreatorSpecification(PropertyInfo propertyInfo, TProperty propertyValue)
            : base(propertyInfo)
        {
            _propertyValue = propertyValue;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            return Enumerable.Empty<ValidateResult>();
        }

        public override void Apply(IEntityCreatorBuilder<TResult, TSchema> builder)
        {
            var translator = new SetPropertyTranslator<TResult, TProperty, TSchema>(builder.ImplementationType, ResultPropertyInfo, _propertyValue);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}