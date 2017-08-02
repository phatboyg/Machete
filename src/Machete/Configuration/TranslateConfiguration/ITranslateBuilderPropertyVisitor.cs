namespace Machete.TranslateConfiguration
{
    using System;
    using System.Reflection;


    public interface ITranslateBuilderPropertyVisitor<TEntity, TInput, TSchema>
        where TEntity : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        void Property(PropertyInfo property);

        void Value<T>(PropertyInfo property);

        void ValueList<T>(PropertyInfo property);

        void Entity(PropertyInfo property, Type entityType);
        void EntityList(PropertyInfo property, Type entityType);
        void Layout(PropertyInfo property, Type layoutType);
        void LayoutList(PropertyInfo property, Type layoutType);
    }
}