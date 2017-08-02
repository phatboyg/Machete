namespace Machete.TranslateConfiguration.Visitors
{
    using System.Reflection;


    public interface ITranslateBuilderPropertyReflector<in TVisitor, TSchema>
        where TVisitor : ITranslateBuilderPropertyVisitor<TSchema>
        where TSchema : Entity
    {
        void Property(TVisitor visitor, PropertyInfo property);
    }
}