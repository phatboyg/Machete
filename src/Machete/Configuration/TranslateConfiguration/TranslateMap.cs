namespace Machete.TranslateConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;


    public abstract class TranslateMap<TResult, TInput, TSchema> :
        ITranslateSpecification<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly ITranslateSpecification<TResult, TInput, TSchema> _specification;

        protected TranslateMap()
        {
            _specification = new TranslateSpecification<TResult, TInput, TSchema>();
        }

        void ITranslateSpecification<TResult, TInput, TSchema>.Apply(ITranslateBuilder<TResult, TInput, TSchema> builder)
        {
            _specification.Apply(builder);
        }

        public void Add(ITranslatePropertySpecification<TResult, TInput, TSchema> specification)
        {
            _specification.Add(specification);
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            return _specification.Validate();
        }

        /// <summary>
        /// Copy the value from the input to the result, using the same property name on the input as the result
        /// </summary>
        /// <param name="propertyExpression">The property reference expression</param>
        /// <typeparam name="T">The value type</typeparam>
        protected void Copy<T>(Expression<Func<TResult, Value<T>>> propertyExpression)
        {
            var specification = new CopyInputValueTranslatePropertySpecification<TResult, T, TInput, TSchema>(propertyExpression);

            _specification.Add(specification);
        }

        /// <summary>
        /// Copy the value from the input value to the result value, allowing a specific input property to be specified. This overrides the default
        /// behavior of mapping the input property of the same name to the result.
        /// </summary>
        /// <param name="propertyExpression">The property reference expression</param>
        /// <param name="inputPropertyExpression">The input property reference expression</param>
        /// <typeparam name="T">The value type</typeparam>
        protected void Copy<T>(Expression<Func<TResult, Value<T>>> propertyExpression, Expression<Func<TInput, Value<T>>> inputPropertyExpression)
        {
            var specification = new CopyInputValueTranslatePropertySpecification<TResult, T, TInput, TSchema>(propertyExpression, inputPropertyExpression);

            _specification.Add(specification);
        }
    }
}