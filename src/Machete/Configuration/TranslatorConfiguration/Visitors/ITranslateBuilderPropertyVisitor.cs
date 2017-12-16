namespace Machete.TranslatorConfiguration.Visitors
{
    using System.Reflection;


    public interface ITranslateBuilderPropertyVisitor<in TSchema>
        where TSchema : Entity
    {
        void Property(PropertyInfo property);

        void Value<T>(PropertyInfo property);

        void ValueList<T>(PropertyInfo property);

        void Entity<T>(PropertyInfo property)
            where T : TSchema;

        void EntityList<T>(PropertyInfo property)
            where T : TSchema;

        void Layout<T>(PropertyInfo property)
            where T : Layout;

        void LayoutList<T>(PropertyInfo property)
            where T : Layout;
    }
}