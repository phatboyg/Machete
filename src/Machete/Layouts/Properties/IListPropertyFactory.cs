namespace Machete.Layouts.Properties
{
    public interface IListPropertyFactory<in T, out TProperty>
    {
        TProperty CreateProperty();
        TProperty CreateProperty(T value);
    }
}