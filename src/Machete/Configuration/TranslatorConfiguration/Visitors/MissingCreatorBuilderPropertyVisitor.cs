namespace Machete.TranslatorConfiguration.Visitors
{
    using System.Reflection;
    using Specifications;


    /// <summary>
    ///     Adds a copy translate property for the properties visited
    /// </summary>
    public abstract class MissingCreatorBuilderPropertyVisitor<TResult, TSchema> :
        TranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly IEntityCreatorBuilder<TResult, TSchema> _builder;

        protected MissingCreatorBuilderPropertyVisitor(IEntityCreatorBuilder<TResult, TSchema> builder)
        {
            _builder = builder;
        }

        public override void Value<T>(PropertyInfo property)
        {
            var specification = new SetPropertyCreatorSpecification<TResult, Value<T>, TSchema>(property, Machete.Value.Missing<T>());

            specification.Apply(_builder);
        }

        public override void ValueList<T>(PropertyInfo property)
        {
            var specification = new SetPropertyCreatorSpecification<TResult, ValueList<T>, TSchema>(property, Machete.ValueList.Missing<T>());

            specification.Apply(_builder);
        }

        public override void Entity<T>(PropertyInfo property)
        {
            var specification = new SetPropertyCreatorSpecification<TResult, Entity<T>, TSchema>(property, Schema.Entity.Missing<T>());

            specification.Apply(_builder);
        }

        public override void EntityList<T>(PropertyInfo property)
        {
            var specification = new SetPropertyCreatorSpecification<TResult, EntityList<T>, TSchema>(property, Machete.EntityList.Missing<T>());

            specification.Apply(_builder);
        }

        public override void Layout<T>(PropertyInfo property)
        {
            var specification = new SetPropertyCreatorSpecification<TResult, Layout<T>, TSchema>(property, Schema.Layout.Missing<T>());

            specification.Apply(_builder);
        }

        public override void LayoutList<T>(PropertyInfo property)
        {
            var specification = new SetPropertyCreatorSpecification<TResult, LayoutList<T>, TSchema>(property, Machete.LayoutList.Missing<T>());

            specification.Apply(_builder);
        }
    }
}