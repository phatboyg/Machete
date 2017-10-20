namespace Machete.HL7
{
    using System;
    using System.Linq.Expressions;
    using Internals.Extensions;
    using Machete.SchemaConfiguration;
    using Machete.SchemaConfiguration.Specifications;


    public abstract class HL7EntityMap<TEntity, TSchema> :
        EntityMap<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : HL7Entity
    {
        readonly IEntityConfigurator<TEntity, TSchema> _configurator;

        protected HL7EntityMap()
        {
            _configurator = this;
        }

        /// <summary>
        /// Map a free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, Value<FT>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, FT>(propertyInfo, position, HL7ValueConverters.FT, HL7ValueFormatters.FT);

            configure?.Invoke(specification);

            _configurator.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map a repeating free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, ValueList<FT>>> propertyExpression, int position, Action<IPropertyListConfigurator> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, FT>(propertyInfo, position, HL7ValueConverters.FT, HL7ValueFormatters.FT);

            configure?.Invoke(specification);

            _configurator.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map a free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, Value<TX>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new ValuePropertySpecification<TEntity, TSchema, TX>(propertyInfo, position, HL7ValueConverters.TX, HL7ValueFormatters.TX);

            configure?.Invoke(specification);

            _configurator.Add(propertyInfo.Name, specification);
        }

        /// <summary>
        /// Map a repeating free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, ValueList<TX>>> propertyExpression, int position, Action<IPropertyListConfigurator> configure = null)
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new PropertyListPropertySpecification<TEntity, TSchema, TX>(propertyInfo, position, HL7ValueConverters.TX, HL7ValueFormatters.TX);

            configure?.Invoke(specification);

            _configurator.Add(propertyInfo.Name, specification);
        }
    }
}