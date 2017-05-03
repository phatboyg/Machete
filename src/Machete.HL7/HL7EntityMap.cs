namespace Machete.HL7
{
    using System;
    using System.Linq.Expressions;


    public class HL7EntityMap<TEntity> :
        EntityMap<TEntity, HL7Entity>
        where TEntity : HL7Entity
    {
        /// <summary>
        /// Map a free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, Value<FT>>> propertyExpression, int position, Action<IValueConfigurator<FT>> configure = null)
        {
        }

        /// <summary>
        /// Map a repeating free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, ValueList<FT>>> propertyExpression, int position, Action<IValueListConfigurator<FT>> configure = null)
        {
        }

        /// <summary>
        /// Map a free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, Value<TX>>> propertyExpression, int position, Action<IValueConfigurator<TX>> configure = null)
        {
        }

        /// <summary>
        /// Map a repeating free text property
        /// </summary>
        /// <param name="propertyExpression"></param>
        /// <param name="position"></param>
        /// <param name="configure"></param>
        protected void Value(Expression<Func<TEntity, ValueList<TX>>> propertyExpression, int position, Action<IValueListConfigurator<TX>> configure = null)
        {
        }
    }
}