namespace Machete.Layouts.Properties
{
    public interface IPropertyListItemFactory<in T, out TProperty>
    {
        TProperty CreateMissing();
        TProperty Create(T value);
    }
}