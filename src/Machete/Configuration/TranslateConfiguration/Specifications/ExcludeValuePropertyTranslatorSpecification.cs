namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;
    using Translators.PropertyTranslaters;


    public class ExcludeValuePropertyTranslatorSpecification<TResult, TValue, TInput, TSchema> :
        IPropertyTranslatorSpecification<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly PropertyInfo _property;

        public ExcludeValuePropertyTranslatorSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression)
        {
            _property = propertyExpression.GetPropertyInfo();
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return Enumerable.Empty<ValidateResult>();
        }

        public IEnumerable<Type> GetReferencedTranslateTypes()
        {
            return Enumerable.Empty<Type>();
        }

        public  void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new ExcludeValuePropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, _property);

            builder.Add(_property.Name, translator);
        }
    }
}