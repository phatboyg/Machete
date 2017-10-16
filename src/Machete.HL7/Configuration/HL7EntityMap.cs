namespace Machete.HL7
{
    using System;
    using System.Linq.Expressions;
    using Machete.SchemaConfiguration;


    public class HL7EntityMap<TEntity, TSchema> :
        EntityMap<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : HL7Entity
    {
        /// <summary>
        /// Map a free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, Value<FT>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
        {
        }

        /// <summary>
        /// Map a repeating free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, ValueList<FT>>> propertyExpression, int position, Action<IPropertyListConfigurator> configure = null)
        {
        }

        /// <summary>
        /// Map a free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, Value<TX>>> propertyExpression, int position, Action<IPropertyConfigurator> configure = null)
        {
        }

        /// <summary>
        /// Map a repeating free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, ValueList<TX>>> propertyExpression, int position, Action<IPropertyListConfigurator> configure = null)
        {
        }
    }
}