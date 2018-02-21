namespace Machete.TranslatorConfiguration.Visitors
{
    using System.Reflection;


    /// <summary>
    /// The default entity visitor, which just dispatches to known types
    /// </summary>
    public abstract class TranslateBuilderPropertyVisitor<TSchema> :
        ITranslateBuilderPropertyVisitor<TSchema>
        where TSchema : Entity
    {
        public abstract void Property(PropertyInfo property);

        public abstract void Value<T>(PropertyInfo property);

        public abstract void ValueList<T>(PropertyInfo property);

        public abstract void Entity<T>(PropertyInfo property)
            where T : TSchema;

        public abstract void EntityList<T>(PropertyInfo property)
            where T : TSchema;

        public abstract void Layout<T>(PropertyInfo property)
            where T : Layout;

        public abstract void LayoutList<T>(PropertyInfo property)
            where T : Layout;
    }
}