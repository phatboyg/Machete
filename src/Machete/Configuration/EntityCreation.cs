namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using TranslatorConfiguration;
    using TranslatorConfiguration.Configurators;
    using TranslatorConfiguration.Specifications;
    using Values;


    public abstract class EntityCreation<TResult, TSchema> :
        IEntityCreatorSpecification<TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly EntityCreatorSpecification<TResult, TSchema> _specification;

        protected EntityCreation()
        {
            _specification = new EntityCreatorSpecification<TResult, TSchema>
            {
                Name = GetType().Name
            };
        }

        void IEntityCreatorSpecification<TResult, TSchema>.Apply(IEntityCreatorBuilder<TResult, TSchema> builder)
        {
            _specification.Apply(builder);
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            return _specification.Validate();
        }

        public string Name
        {
            get => _specification.Name;
            set => _specification.Name = value;
        }

        /// <summary>
        /// Set the value using the specified value provider
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="valueProvider"></param>
        /// <typeparam name="T"></typeparam>
        protected void Set<T>(Expression<Func<TResult, Value<T>>> propertyExpression, SetValueProvider<TSchema, T> valueProvider)
        {
            var specification = new SetValuePropertyCreatorSpecification<TResult, T, TSchema>(propertyExpression, valueProvider);

            _specification.Add(specification);
        }

        /// <summary>
        /// Set the value using the specified value provider
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="valueProvider"></param>
        /// <typeparam name="T"></typeparam>
        protected void Set<T>(Expression<Func<TResult, Value<T>>> propertyExpression, SetValueTypeProvider<TSchema, T> valueProvider)
            where T : struct
        {
            Value<T> ValueProvider(TranslateContext<TSchema> context)
            {
                var value = valueProvider(context);

                return new ConstantValue<T>(value);
            }

            var specification = new SetValuePropertyCreatorSpecification<TResult, T, TSchema>(propertyExpression, ValueProvider);

            _specification.Add(specification);
        }

        /// <summary>
        /// Set the value using the specified value provider
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="valueProvider"></param>
        /// <typeparam name="T"></typeparam>
        protected void Set<T>(Expression<Func<TResult, Value<T>>> propertyExpression, SetNullableValueTypeProvider<TSchema, T> valueProvider)
            where T : struct
        {
            Value<T> ValueProvider(TranslateContext<TSchema> context)
            {
                var value = valueProvider(context);

                return new ConstantValue<T>(value ?? default, value.HasValue);
            }

            var specification = new SetValuePropertyCreatorSpecification<TResult, T, TSchema>(propertyExpression, ValueProvider);

            _specification.Add(specification);
        }

        /// <summary>
        /// Set the value using the specified value provider
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="configure"></param>
        /// <typeparam name="T"></typeparam>
        protected void Set<T>(Expression<Func<TResult, Value<T>>> propertyExpression, Action<ICreateEntityUsingConfigurator<T, TSchema>> configure)
            where T : TSchema
        {
            var specification = new CreateEntityValueUsingConfigurator<TResult, T, TSchema>(_specification, propertyExpression);

            configure?.Invoke(specification);
        }
    }
}