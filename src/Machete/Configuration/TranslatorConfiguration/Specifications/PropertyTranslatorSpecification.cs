namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;


    public abstract class PropertyTranslatorSpecification<TResult, TProperty, TInput, TSchema> :
        IPropertyTranslatorSpecification<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        PropertyInfo _inputPropertyInfo;

        protected PropertyTranslatorSpecification(Expression<Func<TResult, TProperty>> propertyExpression)
        {
            ResultPropertyInfo = propertyExpression.GetPropertyInfo();
        }

        protected PropertyTranslatorSpecification(PropertyInfo propertyInfo)
        {
            ResultPropertyInfo = propertyInfo;
        }

        protected PropertyTranslatorSpecification(Expression<Func<TResult, TProperty>> propertyExpression, Expression<Func<TInput, TProperty>> inputPropertyExpression)
        {
            ResultPropertyInfo = propertyExpression.GetPropertyInfo();

            _inputPropertyInfo = inputPropertyExpression.GetPropertyInfo();
        }

        protected PropertyInfo ResultPropertyInfo { get; }

        protected PropertyInfo InputPropertyInfo
        {
            get
            {
                if (_inputPropertyInfo != null)
                    return _inputPropertyInfo;

                ConfigureInputProperty();

                return _inputPropertyInfo;
            }
        }

        void ConfigureInputProperty()
        {
            _inputPropertyInfo = typeof(TInput) == typeof(TResult)
                ? ResultPropertyInfo
                : typeof(TInput).GetProperty(ResultPropertyInfo.Name);
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            if (ResultPropertyInfo == null)
                yield return this.Error("Property not found", $"{TypeCache<TResult>.ShortName}.{ResultPropertyInfo?.Name}");
            if (InputPropertyInfo == null)
                yield return this.Error("Property not found", $"{TypeCache<TInput>.ShortName}.{ResultPropertyInfo?.Name}");

            if (ResultPropertyInfo != null)
            {
                var propertyInfo = typeof(TResult).GetProperty(ResultPropertyInfo.Name);
                if (propertyInfo == null)
                    yield return this.Error("Property not found", $"{TypeCache<TResult>.ShortName}.{ResultPropertyInfo.Name}");
                else
                {
                    if (propertyInfo.PropertyType != ResultPropertyInfo.PropertyType)
                        yield return this.Error("Property type mismatch",
                            $"{TypeCache<TResult>.ShortName}.{ResultPropertyInfo?.Name} ({TypeCache.GetShortName(ResultPropertyInfo.PropertyType)})");
                }
            }

            foreach (var result in Validate())
            {
                yield return result;
            }
        }

        protected abstract IEnumerable<ValidateResult> Validate();

        public abstract void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder);
    }
}