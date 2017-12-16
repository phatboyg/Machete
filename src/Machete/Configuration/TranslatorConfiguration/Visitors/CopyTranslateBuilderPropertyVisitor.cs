namespace Machete.TranslatorConfiguration.Visitors
{
    using System.Reflection;
    using Specifications;


    /// <summary>
    /// Adds a copy translate property for the properties visited
    /// </summary>
    public abstract class CopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> :
        TranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly IEntityTranslatorBuilder<TResult, TInput, TSchema> _builder;

        protected CopyTranslateBuilderPropertyVisitor(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            _builder = builder;
        }

        public override void Value<T>(PropertyInfo property)
        {
            var specification = new CopyValuePropertyTranslatorSpecification<TResult, T, TInput, TSchema>(property);

            specification.Apply(_builder);
        }

        public override void ValueList<T>(PropertyInfo property)
        {
            var specification = new CopyValueListPropertyTranslatorSpecification<TResult, T, TInput, TSchema>(property);

            specification.Apply(_builder);
        }

        public override void Entity<T>(PropertyInfo property)
        {
        }

        public override void EntityList<T>(PropertyInfo property)
        {
        }

        public override void Layout<T>(PropertyInfo property)
        {
        }

        public override void LayoutList<T>(PropertyInfo property)
        {
        }
    }
}