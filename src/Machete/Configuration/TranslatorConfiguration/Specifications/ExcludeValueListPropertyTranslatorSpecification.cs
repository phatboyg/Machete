namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;
    using Translators.PropertyTranslators;


    public class ExcludeValueListPropertyTranslatorSpecification<TResult, TValue, TInput, TSchema> :
        IPropertyTranslatorSpecification<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly PropertyInfo _property;

        public ExcludeValueListPropertyTranslatorSpecification(Expression<Func<TResult, ValueList<TValue>>> propertyExpression)
        {
            _property = propertyExpression.GetPropertyInfo();
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return Enumerable.Empty<ValidateResult>();
        }

        public void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new ExcludeValueListPropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, _property);

            builder.Add(_property.Name, translator);
        }
    }
}