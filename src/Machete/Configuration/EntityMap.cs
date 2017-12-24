namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Internals.Extensions;
    using SchemaConfiguration;
    using SchemaConfiguration.Builders;
    using SchemaConfiguration.Specifications;
    using Values;
    using Values.Converters;
    using Values.Formatters;


    /// <summary>
    /// An entity map is created to define the mapping of text fragments to an entity, as well
    /// as the reverse -- an entity to text fragments.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public abstract class EntityMap<TEntity, TSchema> :
        ISchemaSpecification<TSchema>,
        IEntityConfigurator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly EntitySpecification<TEntity, TSchema> _specification;

        protected EntityMap()
        {
            _specification = new EntitySpecification<TEntity, TSchema>();
        }

        public Type EntityType => _specification.EntityType;

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            return _specification.GetReferencedEntityTypes();
        }

        void ISchemaSpecification<TSchema>.Apply(ISchemaBuilder<TSchema> builder)
        {
            _specification.Apply(builder);
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            return _specification.Validate();
        }

        protected string Name
        {
            set => _specification.Name = value;
        }

        string IEntityConfigurator<TEntity, TSchema>.Name
        {
            set => _specification.Name = value;
        }

        void IEntityConfigurator<TEntity, TSchema>.Add(string propertyName, IEntityPropertySpecification<TEntity, TSchema> specification)
        {
            _specification.Add(propertyName, specification);
        }

        IEntitySelector IEntityConfigurator<TEntity, TSchema>.EntitySelector
        {
            set => _specification.EntitySelector = value;
        }

        EntityFormatterFactory<TEntity> IEntityConfigurator<TEntity, TSchema>.FormatterFactory
        {
            set => _specification.FormatterFactory = value;
        }

        protected IEntitySelector EntitySelector
        {
            set => _specification.EntitySelector = value;
        }

        /// <summary>
        /// Map an entity property
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Entity<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
            where T : TSchema
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Entity<T>(Expression<Func<TEntity, ValueList<T>>> propertyExpression, int position, Action<IPropertyListConfigurator> configure = null)
            where T : TSchema
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityListPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the value
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<string>>> propertyExpression, int position, Action<IPropertyConfigurator<string>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, string>(propertyInfo, position, ValueConverters.String, ValueFormatters.String);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<byte>>> propertyExpression, int position, Action<IPropertyConfigurator<byte>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, byte>(propertyInfo, position, ValueConverters.Byte, ValueFormatters.Byte);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<bool>>> propertyExpression, int position, Action<IPropertyConfigurator<bool>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, bool>(propertyInfo, position, ValueConverters.Boolean, ValueFormatters.Boolean);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<short>>> propertyExpression, int position, Action<IPropertyConfigurator<short>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, short>(propertyInfo, position, ValueConverters.Short, ValueFormatters.Short);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<int>>> propertyExpression, int position, Action<IPropertyConfigurator<int>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, int>(propertyInfo, position, ValueConverters.Int, ValueFormatters.Int);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<long>>> propertyExpression, int position, Action<IPropertyConfigurator<long>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, long>(propertyInfo, position, ValueConverters.Long, ValueFormatters.Long);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<decimal>>> propertyExpression, int position, Action<IPropertyConfigurator<decimal>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, decimal>(propertyInfo, position, ValueConverters.Decimal, ValueFormatters.Decimal);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<Guid>>> propertyExpression, int position, Action<IPropertyConfigurator<Guid>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, Guid>(propertyInfo, position, ValueConverters.Guid, ValueFormatters.Guid);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<DateTimeOffset>>> propertyExpression, int position, Action<IPropertyConfigurator<DateTimeOffset>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, DateTimeOffset>(propertyInfo, position,
                ValueConverters.DateTimeOffset, ValueFormatters.DateTimeOffset);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<DateTime>>> propertyExpression, int position, Action<IPropertyConfigurator<DateTime>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, DateTime>(propertyInfo, position,
                ValueConverters.DateTime, ValueFormatters.DateTime);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<string>>> propertyExpression, int position, Action<IPropertyListConfigurator<string>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, string>(propertyInfo, position, ValueConverters.String, ValueFormatters.String);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<byte>>> propertyExpression, int position, Action<IPropertyListConfigurator<byte>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, byte>(propertyInfo, position, ValueConverters.Byte, ValueFormatters.Byte);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<short>>> propertyExpression, int position, Action<IPropertyListConfigurator<short>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, short>(propertyInfo, position,
                ValueConverters.Short, ValueFormatters.Short);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<bool>>> propertyExpression, int position, Action<IPropertyListConfigurator<bool>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, bool>(propertyInfo, position,
                ValueConverters.Boolean, ValueFormatters.Boolean);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<int>>> propertyExpression, int position, Action<IPropertyListConfigurator<int>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, int>(propertyInfo, position, ValueConverters.Int, ValueFormatters.Int);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<long>>> propertyExpression, int position, Action<IPropertyListConfigurator<long>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, long>(propertyInfo, position, ValueConverters.Long, ValueFormatters.Long);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<decimal>>> propertyExpression, int position, Action<IPropertyListConfigurator<decimal>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification =
                new PropertyListPropertySpecification<TEntity, TSchema, decimal>(propertyInfo, position, ValueConverters.Decimal, ValueFormatters.Decimal);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<Guid>>> propertyExpression, int position, Action<IPropertyListConfigurator<Guid>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, Guid>(propertyInfo, position, ValueConverters.Guid, ValueFormatters.Guid);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<DateTimeOffset>>> propertyExpression, int position,
            Action<IPropertyListConfigurator<DateTimeOffset>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, DateTimeOffset>(propertyInfo, position, ValueConverters.DateTimeOffset,
                ValueFormatters.DateTimeOffset);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<DateTime>>> propertyExpression, int position, Action<IPropertyListConfigurator<DateTime>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, DateTime>(propertyInfo, position, ValueConverters.DateTime, ValueFormatters.DateTime);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Set the property using the value provider specified.
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="valueProvider">A value provider delegate to set the property</param>
        /// <param name="configure"></param>
        protected void Set<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, SetValueProvider<T> valueProvider, Action<IPropertyConfigurator> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var converter = new SetValueConverter<T>(valueProvider);

            var specification = new SetValuePropertySpecification<TEntity, TSchema, T>(propertyInfo, converter);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Set the property using the value provider specified.
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="valueProvider">A value provider delegate to set the property</param>
        /// <param name="configure"></param>
        protected void Set<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, SetValueTypeProvider<T> valueProvider, Action<IPropertyConfigurator> configure = null)
            where T : struct
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var converter = new SetValueTypeConverter<T>(valueProvider);

            var specification = new SetValuePropertySpecification<TEntity, TSchema, T>(propertyInfo, converter);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Set the property using the value provider specified.
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="valueProvider">A value provider delegate to set the property</param>
        /// <param name="configure"></param>
        protected void Set<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, SetNullableValueTypeProvider<T> valueProvider, Action<IPropertyConfigurator> configure = null)
            where T : struct
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var converter = new SetNullableValueTypeConverter<T>(valueProvider);

            var specification = new SetValuePropertySpecification<TEntity, TSchema, T>(propertyInfo, converter);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Set the property using the value provider specified.
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="valueProvider">A value provider delegate to set the property</param>
        protected void Set<T>(Expression<Func<TEntity, ValueList<T>>> propertyExpression, SetValueListProvider<T> valueProvider)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new SetValueListPropertySpecification<TEntity, TSchema, T>(propertyInfo, valueProvider);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Initialize the value when created
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="value">The initial value</param>
        protected void Init<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, T value)
        {
            var propertyName = propertyExpression.GetPropertyInfo().Name;

            var specification = new InitializeValuePropertySpecification<TEntity, TSchema, T>(propertyName, value);

            _specification.Add(propertyName, specification);
        }
    }
}