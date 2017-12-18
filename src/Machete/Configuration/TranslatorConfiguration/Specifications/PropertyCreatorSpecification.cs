namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;


    public abstract class PropertyCreatorSpecification<TResult, TProperty, TSchema> :
        IPropertyCreatorSpecification<TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        protected PropertyCreatorSpecification(Expression<Func<TResult, TProperty>> propertyExpression)
        {
            ResultPropertyInfo = propertyExpression.GetPropertyInfo();
        }

        protected PropertyCreatorSpecification(PropertyInfo propertyInfo)
        {
            ResultPropertyInfo = propertyInfo;
        }

        protected PropertyInfo ResultPropertyInfo { get; }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            if (ResultPropertyInfo == null)
                yield return this.Error("Property not found", $"{TypeCache<TResult>.ShortName}.{ResultPropertyInfo?.Name}");

            if (ResultPropertyInfo != null)
            {
                var propertyInfo = typeof(TResult).GetProperty(ResultPropertyInfo.Name);
                if (propertyInfo == null)
                {
                    yield return this.Error("Property not found", $"{TypeCache<TResult>.ShortName}.{ResultPropertyInfo.Name}");
                }
                else
                {
                    if (propertyInfo.PropertyType != ResultPropertyInfo.PropertyType)
                        yield return this.Error("Property type mismatch",
                            $"{TypeCache<TResult>.ShortName}.{ResultPropertyInfo?.Name} ({TypeCache.GetShortName(ResultPropertyInfo.PropertyType)})");
                }
            }

            foreach (var result in Validate())
                yield return result;
        }

        public abstract void Apply(IEntityCreatorBuilder<TResult, TSchema> builder);

        protected abstract IEnumerable<ValidateResult> Validate();
    }
}