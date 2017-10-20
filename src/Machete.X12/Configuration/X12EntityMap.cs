﻿namespace Machete.X12.Configuration
{
    using System;
    using System.Linq.Expressions;
    using Internals.Extensions;
    using Machete.SchemaConfiguration;
    using Machete.SchemaConfiguration.Specifications;
    using Values.Converters;
    using Values.Formatters;


    public abstract class X12EntityMap<TEntity, TSchema> :
        EntityMap<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : X12Entity
    {
        readonly IEntityConfigurator<TEntity, TSchema> _configurator;

        protected X12EntityMap()
        {
            _configurator = this;
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, Value<DateTimePeriod>>> propertyExpression, int position, Action<IPropertyConfigurator<DateTimePeriod>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new FormatPropertySpecification<TEntity, TSchema, DateTimePeriod>(propertyInfo, position,
                X12ValueConverters.DateTimePeriod, X12ValueFormatters.DateTimePeriod);

            configure?.Invoke(specification);

            _configurator.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map the property
        /// </summary>
        /// <param name="propertyExpression">A property expression</param>
        /// <param name="position">The value position</param>
        /// <param name="configure">A delegate to configure the property map</param>
        protected void Value(Expression<Func<TEntity, ValueList<DateTimePeriod>>> propertyExpression, int position,
            Action<IPropertyListConfigurator<DateTimePeriod>> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, DateTimePeriod>(propertyInfo, position, X12ValueConverters.DateTimePeriod,
                X12ValueFormatters.DateTimePeriod);

            configure?.Invoke(specification);

            _configurator.Add(propertyInfo.Name, specification);
        }
    }
}