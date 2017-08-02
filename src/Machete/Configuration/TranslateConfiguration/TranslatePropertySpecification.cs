namespace Machete.TranslateConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;


    public abstract class TranslatePropertySpecification<TResult, TProperty, TInput, TSchema> :
        ITranslatePropertySpecification<TResult, TProperty, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        PropertyInfo _inputPropertyInfo;

        protected TranslatePropertySpecification(Expression<Func<TResult, TProperty>> propertyExpression)
        {
            ResultPropertyInfo = propertyExpression.GetPropertyInfo();
        }

        protected TranslatePropertySpecification(PropertyInfo propertyInfo)
        {
            ResultPropertyInfo = propertyInfo;
        }

        protected TranslatePropertySpecification(Expression<Func<TResult, TProperty>> propertyExpression, Expression<Func<TInput, TProperty>> inputPropertyExpression)
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

            foreach (var result in Validate())
            {
                yield return result;
            }
        }

        protected abstract IEnumerable<ValidateResult> Validate();

        public virtual IEnumerable<Type> GetReferencedTranslateTypes()
        {
            yield break;
        }

        public abstract void Apply(ITranslateBuilder<TResult, TInput, TSchema> builder);
    }
}