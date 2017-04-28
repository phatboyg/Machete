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
        protected void Entity<T>(Expression<Func<TEntity, Value<T>>> propertyExpression, int position, Action<IEntityValueConfigurator<T>> configure = null)
            where T : TSchema
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityValuePropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the value
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<string>>> propertyExpression, int position, Action<IValueConfigurator<string>> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<byte>>> propertyExpression, int position, Action<IValueConfigurator<byte>> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<short>>> propertyExpression, int position, Action<IValueConfigurator<short>> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<int>>> propertyExpression, int position, Action<IValueConfigurator<int>> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<long>>> propertyExpression, int position, Action<IValueConfigurator<long>> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<decimal>>> propertyExpression, int position, Action<IValueConfigurator<decimal>> configure = null)
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
        protected void Value(Expression<Func<TEntity, Value<Guid>>> propertyExpression, int position, Action<IValueConfigurator<Guid>> configure = null)
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
            Action<IDateTimeValueConfigurator<DateTimeOffset>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatValuePropertySpecification<TEntity, TSchema, DateTimeOffset>(propertyInfo, position,
                x => new DateTimeOffsetValueConverter(), ValueFormatters.DateTimeOffset);

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
            Action<IDateTimeValueConfigurator<DateTime>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatValuePropertySpecification<TEntity, TSchema, DateTime>(propertyInfo, position, x => new DateTimeValueConverter(),
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
        protected void Entity<T>(Expression<Func<TEntity, ValueArray<T>>> propertyExpression, int position, Action<IValueArrayConfigurator<T>> configure = null)
            where T : TSchema
        {
//            var propertyInfo = propertyExpression.GetPropertyInfo();

//            var specification = new ComponentPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

//            configure?.Invoke(specification);

            //          _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<string>>> propertyExpression, int position,
            Action<IValueArrayConfigurator<string>> configure = null)
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
        protected void Value(Expression<Func<TEntity, ValueArray<byte>>> propertyExpression, int position, Action<IValueArrayConfigurator<byte>> configure = null)
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
            Action<IValueArrayConfigurator<short>> configure = null)
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
        protected void Value(Expression<Func<TEntity, ValueArray<int>>> propertyExpression, int position, Action<IValueArrayConfigurator<int>> configure = null)
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
        protected void Value(Expression<Func<TEntity, ValueArray<long>>> propertyExpression, int position, Action<IValueArrayConfigurator<long>> configure = null)
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
            Action<IValueArrayConfigurator<decimal>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification =
                new ValueArrayPropertySpecification<TEntity, TSchema, decimal>(propertyInfo, position, ValueConverters.Decimal, ValueFormatters.Decimal);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueArray<Guid>>> propertyExpression, int position, Action<IValueArrayConfigurator<Guid>> configure = null)
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
        protected void Entity<T>(Expression<Func<TEntity, ValueList<T>>> propertyExpression, int position, Action<IValueListConfigurator<T>> configure = null)
            where T : TSchema
        {
//            var propertyInfo = propertyExpression.GetPropertyInfo();

//            var specification = new ComponentPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

//            configure?.Invoke(specification);

            //          _specification.Add(propertyInfo.Name, specification);
        }


        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value<T>(Expression<Func<TEntity, ValueList<T>>> propertyExpression, int position, Action<IValueListConfigurator<T>> configure = null)
            where T : TSchema
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

//            var specification = new ComponentPropertySpecification<TEntity, TSchema, T>(propertyInfo, position);

//            configure?.Invoke(specification);

            //          _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<string>>> propertyExpression, int position, Action<IValueListConfigurator<string>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification =
                new ValueListPropertySpecification<TEntity, TSchema, string>(propertyInfo, position, ValueConverters.String, ValueFormatters.String);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<byte>>> propertyExpression, int position, Action<IValueListConfigurator<byte>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueListPropertySpecification<TEntity, TSchema, byte>(propertyInfo, position, ValueConverters.Byte, ValueFormatters.Byte);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<short>>> propertyExpression, int position, Action<IValueListConfigurator<short>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification =
                new ValueListPropertySpecification<TEntity, TSchema, short>(propertyInfo, position, ValueConverters.Short, ValueFormatters.Short);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<int>>> propertyExpression, int position, Action<IValueListConfigurator<int>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueListPropertySpecification<TEntity, TSchema, int>(propertyInfo, position, ValueConverters.Int, ValueFormatters.Int);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<long>>> propertyExpression, int position, Action<IValueListConfigurator<long>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueListPropertySpecification<TEntity, TSchema, long>(propertyInfo, position, ValueConverters.Long, ValueFormatters.Long);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<decimal>>> propertyExpression, int position, Action<IValueListConfigurator<decimal>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification =
                new ValueListPropertySpecification<TEntity, TSchema, decimal>(propertyInfo, position, ValueConverters.Decimal, ValueFormatters.Decimal);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<Guid>>> propertyExpression, int position, Action<IValueListConfigurator<Guid>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValueListPropertySpecification<TEntity, TSchema, Guid>(propertyInfo, position, ValueConverters.Guid, ValueFormatters.Guid);

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
            Action<IDateTimeValueConfigurator<DateTimeOffset>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatValueArrayPropertySpecification<TEntity, TSchema, DateTimeOffset>(propertyInfo, position,
                x => new DateTimeOffsetValueConverter(), ValueFormatters.DateTimeOffset);

            configure?.Invoke(specification);

            _specification.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<DateTime>>> propertyExpression, int position, Action<IDateTimeValueConfigurator<DateTime>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification =
                new FormatValueArrayPropertySpecification<TEntity, TSchema, DateTime>(propertyInfo, position, x => new DateTimeValueConverter(),
                    ValueFormatters.DateTime);

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

            var specification = new SetValueArrayPropertySpecification<TEntity, TSchema, T>(propertyInfo, valueProvider);

            _specification.Add(propertyInfo.Name, specification);
        }
    }
}