namespace Machete.TranslateConfiguration
{
    using System;
    using System.Reflection;


    /// <summary>
    /// Adds a copy translate property for the properties visited
    /// </summary>
    public class CopyEntityTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> :
        EntityTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly ITranslateBuilder<TResult, TInput, TSchema> _builder;

        public CopyEntityTranslateBuilderPropertyVisitor(ITranslateBuilder<TResult, TInput, TSchema> builder)
        {
            _builder = builder;
        }

        public override void Value<T>(PropertyInfo property)
        {
            var specification = new CopyInputValueTranslatePropertySpecification<TResult, T, TInput, TSchema>(property);

            specification.Apply(_builder);
        }

        public override void ValueList<T>(PropertyInfo property)
        {
            var specification = new CopyInputValueListTranslatePropertySpecification<TResult, T, TInput, TSchema>(property);

            specification.Apply(_builder);
        }

        public override void Entity(PropertyInfo property, Type entityType)
        {
        }

        public override void EntityList(PropertyInfo property, Type entityType)
        {
        }

        public override void Layout(PropertyInfo property, Type layoutType)
        {
        }

        public override void LayoutList(PropertyInfo property, Type layoutType)
        {
        }
    }
}