namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Internals.Extensions;
    using SchemaConfiguration;
    using SchemaConfiguration.Specifications;
    using Values.Converters;
    using Values.Formatters;


    /// <summary>
    /// An entity map is created to define the mapping of text fragments to an entity, as well
    /// as the reverse -- an entity to text fragments.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public abstract class EntityMap<TEntity, TSchema> :
        ISchemaSpecification<TSchema>
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
            set { _specification.Name = value; }
        }

        protected IEntityTypeSelector EntityTypeSelector
        {
            set { _specification.EntityTypeSelector = value; }
        }

        /// <summary>
        /// Map an entity property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Entity<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, int position, Action<IEntityPropertyConfigurator<T>> configure = null)
            where T : TSchema
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the value
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<string>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<byte>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<short>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<int>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<long>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<decimal>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<Guid>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<DateTimeOffset>>> propertyExpression, int position,
            Action<IDateTimePropertyConfigurator<DateTimeOffset>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatPropertySpecification<TEntity, TSchema, DateTimeOffset>(propertyInfo, position,
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
        protected void Value(Expression<Func<TEntity, Value<DateTime>>> propertyExpression, int position,
            Action<IDateTimePropertyConfigurator<DateTime>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatPropertySpecification<TEntity, TSchema, DateTime>(propertyInfo, position, ValueConverters.DateTime,
                ValueFormatters.DateTime);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Entity<T>(Expression<Func<TEntity, ValueArray<T>>> propertyExpression, int position, Action<IPropertyArrayConfigurator<T>> configure = null)
            where T : TSchema
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityArrayPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<string>>> propertyExpression, int position,
            Action<IPropertyArrayConfigurator<string>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueArrayPropertySpecification<TEntity, TSchema, string>(propertyInfo, position, ValueConverters.String, ValueFormatters.String);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<byte>>> propertyExpression, int position, Action<IPropertyArrayConfigurator<byte>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueArrayPropertySpecification<TEntity, TSchema, byte>(propertyInfo, position, ValueConverters.Byte, ValueFormatters.Byte);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<short>>> propertyExpression, int position,
            Action<IPropertyArrayConfigurator<short>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueArrayPropertySpecification<TEntity, TSchema, short>(propertyInfo, position, ValueConverters.Short, ValueFormatters.Short);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<int>>> propertyExpression, int position, Action<IPropertyArrayConfigurator<int>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueArrayPropertySpecification<TEntity, TSchema, int>(propertyInfo, position, ValueConverters.Int, ValueFormatters.Int);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<long>>> propertyExpression, int position, Action<IPropertyArrayConfigurator<long>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueArrayPropertySpecification<TEntity, TSchema, long>(propertyInfo, position, ValueConverters.Long, ValueFormatters.Long);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<decimal>>> propertyExpression, int position,
            Action<IPropertyArrayConfigurator<decimal>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueArrayPropertySpecification<TEntity, TSchema, decimal>(propertyInfo, position, ValueConverters.Decimal, ValueFormatters.Decimal);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<Guid>>> propertyExpression, int position, Action<IPropertyArrayConfigurator<Guid>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueArrayPropertySpecification<TEntity, TSchema, Guid>(propertyInfo, position, ValueConverters.Guid, ValueFormatters.Guid);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<DateTimeOffset>>> propertyExpression, int position,
            Action<IDateTimePropertyConfigurator<DateTimeOffset>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatValueArrayPropertySpecification<TEntity, TSchema, DateTimeOffset>(propertyInfo, position, ValueConverters.DateTimeOffset,
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
        protected void Value(Expression<Func<TEntity, ValueArray<DateTime>>> propertyExpression, int position, Action<IDateTimePropertyConfigurator<DateTime>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatValueArrayPropertySpecification<TEntity, TSchema, DateTime>(propertyInfo, position, ValueConverters.DateTime, ValueFormatters.DateTime);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Entity<T>(Expression<Func<TEntity, ValueList<T>>> propertyExpression, int position, Action<IPropertyListConfigurator<T>> configure = null)
            where T : TSchema
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityListPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

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

            var specification =
                new PropertyListPropertySpecification<TEntity, TSchema, short>(propertyInfo, position, ValueConverters.Short, ValueFormatters.Short);

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
            Action<IDateTimePropertyConfigurator<DateTimeOffset>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatValueListPropertySpecification<TEntity, TSchema, DateTimeOffset>(propertyInfo, position, ValueConverters.DateTimeOffset,
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
        protected void Value(Expression<Func<TEntity, ValueList<DateTime>>> propertyExpression, int position, Action<IDateTimePropertyConfigurator<DateTime>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatValueListPropertySpecification<TEntity, TSchema, DateTime>(propertyInfo, position, ValueConverters.DateTime, ValueFormatters.DateTime);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Set the property using the value provider specified.
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="valueProvider">A value provider delegate to set the property</param>
        protected void Set<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, Func<TextSlice, T> valueProvider)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new SetValuePropertySpecification<TEntity, TSchema, T>(propertyInfo, valueProvider);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Set the property using the value provider specified.
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="valueProvider">A value provider delegate to set the property</param>
        protected void Set<T>(Expression<Func<TEntity, ValueArray<string>>> propertyExpression, Func<TextSlice, ValueArray<T>> valueProvider)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new SetPropertyArrayPropertySpecification<TEntity, TSchema, T>(propertyInfo, valueProvider);

            _specification.Add(propertyInfo.Name, specification);
        }
    }
}