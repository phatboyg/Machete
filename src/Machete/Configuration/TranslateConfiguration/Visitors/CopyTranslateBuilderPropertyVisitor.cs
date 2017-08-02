namespace Machete.TranslateConfiguration.Visitors
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
        readonly ITranslateBuilder<TResult, TInput, TSchema> _builder;

        protected CopyTranslateBuilderPropertyVisitor(ITranslateBuilder<TResult, TInput, TSchema> builder)
        {
            _builder = builder;
        }

        public override void Value<T>(PropertyInfo property)
        {
            var specification = new CopyInputValuePropertyTranslateSpecification<TResult, T, TInput, TSchema>(property);

            specification.Apply(_builder);
        }

        public override void ValueList<T>(PropertyInfo property)
        {
            var specification = new CopyInputValueListPropertyTranslateSpecification<TResult, T, TInput, TSchema>(property);

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