namespace Machete.TranslateConfiguration.Visitors
{
    using System.Reflection;
    using Specifications;


    /// <summary>
    ///     Adds a copy translate property for the properties visited
    /// </summary>
    public abstract class MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> :
        TranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly ITranslateBuilder<TResult, TInput, TSchema> _builder;

        protected MissingTranslateBuilderPropertyVisitor(ITranslateBuilder<TResult, TInput, TSchema> builder)
        {
            _builder = builder;
        }

        public override void Value<T>(PropertyInfo property)
        {
            var specification = new SetPropertyTranslateSpecification<TResult, Value<T>, TInput, TSchema>(property, Machete.Value.Missing<T>());

            specification.Apply(_builder);
        }

        public override void ValueList<T>(PropertyInfo property)
        {
            var specification = new SetPropertyTranslateSpecification<TResult, ValueList<T>, TInput, TSchema>(property, Machete.ValueList.Missing<T>());

            specification.Apply(_builder);
        }

        public override void Entity<T>(PropertyInfo property)
        {
            var specification = new SetPropertyTranslateSpecification<TResult, Entity<T>, TInput, TSchema>(property, Schema.Entity.Missing<T>());

            specification.Apply(_builder);
        }

        public override void EntityList<T>(PropertyInfo property)
        {
            var specification = new SetPropertyTranslateSpecification<TResult, EntityList<T>, TInput, TSchema>(property, Machete.EntityList.Missing<T>());

            specification.Apply(_builder);
        }

        public override void Layout<T>(PropertyInfo property)
        {
            var specification = new SetPropertyTranslateSpecification<TResult, Layout<T>, TInput, TSchema>(property, Schema.Layout.Missing<T>());

            specification.Apply(_builder);
        }

        public override void LayoutList<T>(PropertyInfo property)
        {
            var specification = new SetPropertyTranslateSpecification<TResult, LayoutList<T>, TInput, TSchema>(property, Machete.LayoutList.Missing<T>());

            specification.Apply(_builder);
        }
    }
}